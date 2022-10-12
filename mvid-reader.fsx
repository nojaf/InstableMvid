#r "nuget: System.Reflection.Metadata"

open System
open System.IO
open System.Reflection.Metadata
open System.Reflection.PortableExecutable

let getMvid refDll =
    use embeddedReader = new PEReader(File.OpenRead refDll)
    let sourceReader = embeddedReader.GetMetadataReader()
    let loc = sourceReader.GetModuleDefinition().Mvid
    let mvid = sourceReader.GetGuid(loc)
    printfn "%s at %s" (mvid.ToString()) (DateTime.Now.ToString())

let refDll =
    Path.Combine(__SOURCE_DIRECTORY__, @"obj\Debug\net7.0\ref\InstableMvid.dll")

getMvid refDll
