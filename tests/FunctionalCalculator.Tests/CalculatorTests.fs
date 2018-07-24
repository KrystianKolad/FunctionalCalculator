namespace FunctionalCalculator.Tests

open System
open NUnit.Framework
open Program.Calculator

[<TestFixture>]
type CalculatorTests () =

    [<Test>]
    member this.Add_2_And_3_Shoud_Give_5 () =
        Assert.That((add 2 3), Is.EqualTo(5))

    [<Test>]
    member this.Subtract_8_And_5_Should_Give_3 () =
        Assert.That((subtract 8 5), Is.EqualTo(3))

    [<Test>]
    member this.Multiply_8_And_5_Should_Give_40 () =
        Assert.That((multiply 8 5), Is.EqualTo(40))

    [<Test>]
    member this.Divide_10_And_5_Should_Give_2 () =
        Assert.That((divide 10 5), Is.EqualTo(2))

    [<Test>]
    member this.Subtract_8_And_0_Should_Fail () =
        Assert.Throws<Exception>(fun _ -> (divide 8 0) |> ignore) |> ignore