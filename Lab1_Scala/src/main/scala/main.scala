import org.scalacheck.Prop.forAll
import org.scalacheck.{Arbitrary, Gen, Prop}
import scala.language.implicitConversions

trait Semigroup[A] {
  def combine(x: A, y: A): A
}

object Semigroup{
  implicit val doubleSemigroup = new Semigroup[Set[Double]] {
    override def combine(x: Set[Double], y: Set[Double]): Set[Double] = x ++ y
  }
}

class SemigroupOps[A: Semigroup](x: A)(implicit g: Semigroup[A]){
  def **(y: A): A = g.combine(x, y)
}

object L1 {
  def main(args: Array[String]): Unit = {
    implicit def sg[A](x: A)(implicit g: Semigroup[A]): SemigroupOps[A] = {
      new SemigroupOps[A](x)
    }
    
/*  var s1 : Set[Double] = Set(1.6, 3.15, 4.14)
  var s2 : Set[Double] = Set(7.21, 1.4, 3.06)
  var s3 : Set[Double] = Set(1.5, 1.08) */

    val associate = forAll { (a: Set[Double], b: Set[Double], c: Set[Double]) =>
(a ** b) ** c == a ** (b ** c)      
    }
    associate.check()
  }
}