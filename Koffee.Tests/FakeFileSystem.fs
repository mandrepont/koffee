﻿namespace Koffee

type FakeFileSystemReader() =
    let unset () = (fun _ -> failwith "Unexpected call")

    member val GetNode = unset () with get, set
    member val GetNodes = unset () with get, set
    member val IsEmpty = unset () with get, set

    interface IFileSystemReader with
        member this.GetNode path = this.GetNode path
        member this.GetNodes showHidden path = this.GetNodes showHidden path
        member this.IsEmpty path = this.IsEmpty path

type FakeFileSystemWriter() =
    let unset () = (fun _ -> failwith "Unexpected call")

    member val Create = unset () with get, set
    member val Move = unset () with get, set
    member val Copy = unset () with get, set
    member val Recycle = unset () with get, set
    member val Delete = unset () with get, set

    interface IFileSystemWriter with
        member this.Create nodeType path = this.Create nodeType path
        member this.Move fromPath toPath = this.Move fromPath toPath
        member this.Copy fromPath toPath = this.Copy fromPath toPath
        member this.Recycle path = this.Recycle path
        member this.Delete path = this.Delete path
