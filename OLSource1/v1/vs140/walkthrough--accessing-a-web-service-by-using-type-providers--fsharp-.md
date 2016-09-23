---
title: "Walkthrough: Accessing a Web Service by Using Type Providers (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - type providers [F#], accessing WSDL
  - WSDL, accessing with F# type providers
ms.assetid: 8b32a601-60a9-4d1c-a4c0-d95b3c6566a8
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Accessing a Web Service by Using Type Providers (F#)
This walkthrough shows you how to use the Web Services Description Language (WSDL) type provider that is available in F# 3.0 to access a WSDL service. In other .NET languages, you generate the code to access the web service by calling svcutil.exe, or by adding a web reference in, for example, a C# project to get Visual Studio to call svcutil.exe for you. In F#, you have the additional option of using the WSDL type provider, so as soon as you write the code that creates the WsdlService type, the types are generated and become available. This process relies on the service being available when you are writing the code.  
  
 This walkthrough illustrates the following tasks. You must complete them in this order for the walkthrough to succeed:  
  
-   [Creating the project](#BKMK_CreateSetupFSProj)  
  
-   [Configuring the type provider](#BKMK_ConfigTypeProv)  
  
-   [Calling the web service, and processing the results](#BKMK_CallWebSvc)  
  
##  <a name="BKMK_CreateSetupFSProj"></a> Creating the project  
 In the step, you create a project and add the appropriate references to use a WSDL type provider.  
  
#### To create and set up an F# project  
  
1.  Open a new F# Console Application project.  
  
2.  In **Solution Explorer**, open the shortcut menu for the project's **Reference** node, and then choose **Add Reference**.  
  
3.  In the **Assemblies** area, choose **Framework**, and then, in the list of available assemblies, choose <xref:System.Runtime.Serialization?qualifyHint=False> and <xref:System.ServiceModel?qualifyHint=False>.  
  
4.  In the **Assemblies** area, choose **Extensions**.  
  
5.  In the list of available assemblies, choose `FSharp.Data.TypeProviders`, and then choose the **OK** button to add references to these assemblies.  
  
##  <a name="BKMK_ConfigTypeProv"></a> Configuring the type provider  
 In this step, you use the WSDL type provider to generate types for the TerraServer web service.  
  
#### To configure the type provider and generate types  
  
1.  Add the following line of code to open the type provider namespace.  
  
    ```f#  
    open System  
    open System.ServiceModel  
    open Microsoft.FSharp.Linq  
    open Microsoft.FSharp.Data.TypeProviders  
  
    ```  
  
2.  Add the following line of code to invoke the type provider with a web service. In this example, use the TerraServer web service.  
  
    ```f#  
  
    type TerraService = WsdlService<" HYPERLINK "http://terraserver-usa.com/TerraService2.asmx?WSDL" http://msrmaps.com/TerraService2.asmx?WSDL">  
  
    ```  
  
     A red squiggle appears under this line of code if the service URI is misspelled or if the service itself is down or isn’t performing. If you point to the code, an error message describes the problem. You can find the same information in the **Error List** window or in the **Output Window** after you build.  
  
     There are two ways to specify configuration settings for a WSDL connection, by using the app.config file for the project, or by using the static type parameters in the type provider declaration. You can use svcutil.exe to generate appropriate configuration file elements. For more information about using svcutil.exe to generate configuration information for a web service, see [ServiceModel Metadata Utility Tool (Svcutil.exe)](assetId:///1abf3d9f-b420-46f1-b628-df238751f308).For a full description of the static type parameters for the WSDL type provider, see [WsdlService Type Provider (F#)](../vs140/wsdlservice-type-provider--fsharp-.md).  
  
##  <a name="BKMK_CallWebSvc"></a> Calling the web service, and processing the results  
 Each web service has its own set of types that are used as parameters for its method calls. In this step, you prepare these parameters, call a web method, and process the information that it returns.  
  
#### To call the web service, and process the results  
  
1.  The web service might time out or stop functioning, so you should include the web service call in an exception handling block. Write the following code to try to get data from the web service.  
  
    ```f#  
    try  
        let terraClient = TerraService.GetTerraServiceSoap ()  
        let myPlace = new TerraService.ServiceTypes.msrmaps.com.Place(City = "Redmond", State = "Washington", Country = "United States")  
        let myLocation = terraClient.ConvertPlaceToLonLatPt(myPlace)  
        printfn "Redmond Latitude: %f Longitude: %f" (myLocation.Lat) (myLocation.Lon)  
    with  
        | :? ServerTooBusyException as exn ->  
            let innerMessage =  
                match (exn.InnerException) with  
                | null -> ""  
                | innerExn -> innerExn.Message  
            printfn "An exception occurred:\n %s\n %s" exn.Message innerMessage  
        | exn -> printfn "An exception occurred: %s" exn.Message  
  
    ```  
  
     Notice that you create the data types that are needed for the web service, such as `Place` and `Location`, as nested types under the WsdlService type `TerraService`.  
  
## See Also  
 [WsdlService Type Provider (F#)](../vs140/wsdlservice-type-provider--fsharp-.md)   
 [Type Providers](../vs140/type-providers.md)