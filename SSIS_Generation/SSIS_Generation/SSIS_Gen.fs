// SSIS_Gen.fs
// Auto Generation of SSIS Package

open System.IO
open System.Collections.Generic
open System.Linq
open System.Text
open Microsoft.SqlServer.Dts.Runtime
open Microsoft.SqlServer.Dts.Pipeline.Wrapper

let TestPackage = new Package()
TestPackage.Name   <- "TestPackage"

let app = new Microsoft.SqlServer.Dts.Runtime.Application()
app.SaveToXml("d:\\test.dtsx",TestPackage,null)
