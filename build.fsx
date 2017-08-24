#load @"paket-files/build/vrvis/Aardvark.Fake/DefaultSetup.fsx"

open Fake
open System
open System.IO
open System.Diagnostics
open Aardvark.Fake

//do MSBuildDefaults <- { MSBuildDefaults with Verbosity = Some Minimal }
do Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

DefaultSetup.install ["src/AssimpNet.sln"]

#if DEBUG
do System.Diagnostics.Debugger.Launch() |> ignore
#endif

entry()
