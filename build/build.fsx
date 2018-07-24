#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators

let artifacts = "../artifacts"
let packages = "../packages"

Target.create "Clean" (fun _ ->
    !! "../src/**/bin"
    ++ "../src/**/obj"
    ++ artifacts
    ++ packages
    |> Shell.cleanDirs 
)

Target.create "Build" (fun _ ->
    !! "../src/**/*.*proj"
    ++ "../tests/**/*.*proj"
    |> Seq.iter (DotNet.build id)
)

Target.create "Test" (fun _ ->
    !! "../tests/**/*.*proj"
    |> Seq.iter (DotNet.test id)
)

Target.create "Publish" (fun _ ->
     DotNet.publish (fun c->
        { c with
            Configuration = DotNet.Release
            OutputPath = Some "../../artifacts"
        }) "../src/FunctionalCalculator"
)

Target.create "All" ignore

"Clean"
  ==> "Build"
  ==> "Test"
  ==> "Publish"
  ==> "All"

Target.runOrDefault "All"
