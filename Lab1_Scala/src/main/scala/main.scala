import org.scalacheck.Prop.forAll
import org.scalacheck.{Arbitrary, Gen, Prop}
import scala.language.implicitConversions

trait Semigroup[A] {
  def combine(x: A, y: A): A
  
  def union(x: A, y: A): A
  
  def intersection(x: A, y: A): A
}

object Semigroup{
  implicit val doubleSemigroup = new Semigroup[Set[Double]] {
    override def combine(x: Set[Double], y: Set[Double]):
    Set[Double] = x ++ y
    
    override def union(x: Set[Double], y: Set[Double]):
    Set[Double] = x | y
    
    override def intersection(x: Set[Double], y: Set[Double]):
    Set[Double] = x & y
  }
}

class SemigroupOps[A: Semigroup](x: A)(implicit g: Semigroup[A]){
  def **(y: A): A = g.combine(x, y)
  
  def ||(y: A): A = g.union(x, y)
  
  def &&(y: A): A = g.intersection(x, y)
}

object L1 {
  def main(args: Array[String]): Unit = {
    implicit def sg[A](x: A)(implicit g: Semigroup[A]): SemigroupOps[A] = {
      new SemigroupOps[A](x)
    }

    val assocComb = forAll { 
      (a: Set[Double], b: Set[Double], c: Set[Double]) =>
      (a ** b) ** c == a ** (b ** c)      
    }
        
    val assocUn = forAll { 
      (a: Set[Double], b: Set[Double], c: Set[Double]) =>
      var s1 : Set[Double] = (a || b) || c
      var s2 : Set[Double] = a || (b || c)
      s1 == s2     
    }
    
    val assocIn = forAll { 
      (a: Set[Double], b: Set[Double], c: Set[Double]) =>
      var s1 : Set[Double] = (a && b) && c
      var s2 : Set[Double] = a && (b && c)
      s1 == s2      
    }
    
    assocComb.check()
    
    assocUn.check()
    
    assocIn.check()
  }
}