---
title: "Calling Code in VSTO Add-ins from Other Office Solutions"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "VBA [Office development in Visual Studio], calling code in application-level add-ins"
  - "application-level add-ins [Office development in Visual Studio], calling code from other solutions"
  - "calling add-in code"
  - "add-ins [Office development in Visual Studio], calling code from other solutions"
  - "interoperability [Office development in Visual Studio]"
  - "calling code from VBA"
ms.assetid: c1f16b4c-9291-49ed-9694-a83a37109612
caps.latest.revision: 54
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Calling Code in VSTO Add-ins from Other Office Solutions
  You can expose an object in your VSTO Add-in to other solutions, including other Microsoft Office solutions. This is useful if your VSTO Add-in provides a service that you want to enable other solutions to use. For example, if you have an VSTO Add-in for Microsoft Office Excel that performs calculations on financial data from a Web service, other solutions can perform these calculations by calling into the Excel VSTO Add-in at run time.  
  
 [!INCLUDE[appliesto_allapp](../VS_officedev/includes/appliesto_allapp_md.md)]  
  
 There are two main steps in this process:  
  
-   In your VSTO Add-in, expose an object to other solutions.  
  
-   In another solution, access the object exposed by your VSTO Add-in, and call members of the object.  
  
## Types of Solutions That Can Call Code in an Add-In  
 You can expose an object in an VSTO Add-in to the following types of solutions:  
  
-   Visual Basic for Applications (VBA) code in a document that is loaded in the same application process as your VSTO Add-in.  
  
-   Document-level customizations that are loaded in the same application process as your VSTO Add-in.  
  
-   Other VSTO Add-ins created by using the Office project templates in Visual Studio.  
  
-   COM VSTO Add-ins (that is, VSTO Add-ins that implement the \<xref:Extensibility.IDTExtensibility2> interface directly).  
  
-   Any solution that is running in a different process than your VSTO Add-in (these types of solutions are also named *out-of-process clients*). These include applications that automate an Office application, such as a Windows Forms or console application, and VSTO Add-ins that are loaded in a different process.  
  
## Exposing Objects to Other Solutions  
 To expose an object in your VSTO Add-in to other solutions, perform the following steps in your VSTO Add-in:  
  
1.  Define a class that you want to expose to other solutions.  
  
2.  Override the \<xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService*> method in the `ThisAddIn` class. Return an instance of the class that you want to expose to other solutions.  
  
### Defining the Class You Want to Expose to Other Solutions  
 At a minimum, the class you want to expose must be public, it must have the \<xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute set to **true**, and it must expose the [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5) interface.  
  
 The recommended way to expose the [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5) interface is to perform the following steps:  
  
1.  Define an interface that declares the members that you want to expose to other solutions. You can define this interface in your VSTO Add-in project. However, you might want to define this interface in a separate class library project if you want to expose the class to non-VBA solutions, so that the solutions that call your VSTO Add-in can reference the interface without referencing your VSTO Add-in project.  
  
2.  Apply the \<xref:System.Runtime.InteropServices.ComVisibleAttribute> attribute to this interface, and set this attribute to **true**.  
  
3.  Modify your class to implement this interface.  
  
4.  Apply the \<xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute to your class, and set this attribute to the None value of the \<xref:System.Runtime.InteropServices.ClassInterfaceType> enumeration.  
  
5.  If you want to expose the class to out-of-process clients, you might also need to do the following:  
  
    -   Derive the class from \<xref:System.Runtime.InteropServices.StandardOleMarshalObject>. For more information, see [Exposing Classes to Out-of-Process Clients](#outofproc).  
  
    -   Set the **Register for COM interop** property in the project where you define the interface. This is necessary only if you want to enable clients to use early binding to call into the VSTO Add-in.  
  
 The following code example demonstrates an `AddInUtilities` class with an `ImportData` method that can be called by other solutions. To see this code in the context of a larger walkthrough, see [Walkthrough: Calling Code in a VSTO Add-in from VBA](../VS_officedev/walkthrough--calling-code-in-a-vsto-add-in-from-vba.md).  
  
 [!code[Trin_AddInInteropWalkthrough#3](../VS_officedev/codesnippet/CSharp/calling-code-in-vsto-add-ins-from-other-office-solutions_1.cs)]
[!code[Trin_AddInInteropWalkthrough#3](../VS_officedev/codesnippet/VisualBasic/calling-code-in-vsto-add-ins-from-other-office-solutions_1.vb)]  
  
### Exposing Classes to VBA  
 When you perform the steps provided above, VBA code can call only the methods that you declare in the interface. VBA code cannot call any other methods in your class, including methods that your class obtains from base classes such as \<xref:System.Object>.  
  
 You can alternatively expose the [IDispatch](assetId:///ebbff4bc-36b2-4861-9efa-ffa45e013eb5) interface by setting the \<xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute to the AutoDispatch or AutoDual value of the \<xref:System.Runtime.InteropServices.ClassInterfaceType> enumeration. If you do this, you do not have to declare the methods in a separate interface. However, VBA code can call any public and non-static methods in your class, including methods obtained from base classes such as \<xref:System.Object>. In addition, out-of-process clients that use early binding cannot call your class.  
  
###  <a name="outofproc"></a> Exposing Classes to Out-of-Process Clients  
 If you want to expose a class in your VSTO Add-in to out-of-process clients, you should derive the class from \<xref:System.Runtime.InteropServices.StandardOleMarshalObject> to ensure that out-of-process clients can call your exposed VSTO Add-in object. Otherwise, attempts to get an instance of your exposed object in an out-of-process client might fail unexpectedly.  
  
 This is because all calls into the object model of an Office application must be made on the main UI thread, but calls from an out-of-process client to your object will arrive on an arbitrary RPC (remote procedure call) thread. The COM marshaling mechanism in the .NET Framework will not switch threads, and it will instead attempt to marshal the call to your object on the incoming RPC thread instead of the main UI thread. If your object is an instance of a class that derives from \<xref:System.Runtime.InteropServices.StandardOleMarshalObject>, incoming calls to your object are automatically marshaled to the thread where the exposed object was created, which will be the main UI thread of the host application.  
  
 For more information about using threads in Office solutions, see [Threading Support in Office](../VS_officedev/threading-support-in-office.md).  
  
### Overriding the RequestComAddInAutomationService Method  
 The following code example demonstrates how to override \<xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService*> in the `ThisAddIn` class in your VSTO Add-in. This example assumes that you have defined a class named `AddInUtilities` that you want to expose to other solutions. To see this code in the context of a larger walkthrough, see [Walkthrough: Calling Code in a VSTO Add-in from VBA](../VS_officedev/walkthrough--calling-code-in-a-vsto-add-in-from-vba.md).  
  
 [!code[Trin_AddInInteropWalkthrough#1](../VS_officedev/codesnippet/CSharp/calling-code-in-vsto-add-ins-from-other-office-solutions_2.cs)]
[!code[Trin_AddInInteropWalkthrough#1](../VS_officedev/codesnippet/VisualBasic/calling-code-in-vsto-add-ins-from-other-office-solutions_2.vb)]  
  
 When your VSTO Add-in is loaded, the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] calls the \<xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService*> method. The runtime assigns the returned object to the \<xref:Microsoft.Office.Core.COMAddIn.Object*> property of a \<xref:Microsoft.Office.Core.COMAddIn> object that represents your VSTO Add-in. This \<xref:Microsoft.Office.Core.COMAddIn> object is available to other Office solutions, and to solutions that automate Office.  
  
## Accessing Objects from Other Solutions  
 To call the exposed object in your VSTO Add-in, perform the following steps in the client solution:  
  
1.  Get the \<xref:Microsoft.Office.Core.COMAddIn> object that represents the exposed VSTO Add-in. Clients can access all of the available VSTO Add-ins by using the Application.COMAddIns property in the object model of the host Office application.  
  
2.  Access the \<xref:Microsoft.Office.Core.COMAddIn.Object*> property of the \<xref:Microsoft.Office.Core.COMAddIn> object. This property returns the exposed object from the VSTO Add-in.  
  
3.  Call the members of the exposed object.  
  
 The way that you use the return value of the \<xref:Microsoft.Office.Core.COMAddIn.Object*> property is different for VBA clients and non-VBA clients. For out-of-process clients, additional code is necessary to avoid a possible race condition.  
  
### Accessing Objects from VBA Solutions  
 The following code example demonstrates how to use VBA to call a method that is exposed by an VSTO Add-in. This VBA macro calls a method named `ImportData` that is defined in an VSTO Add-in that is named **ExcelImportData**. To see this code in the context of a larger walkthrough, see [Walkthrough: Calling Code in a VSTO Add-in from VBA](../VS_officedev/walkthrough--calling-code-in-a-vsto-add-in-from-vba.md).  
  
```  
Sub CallVSTOMethod()  
    Dim addIn As COMAddIn  
    Dim automationObject As Object  
    Set addIn = Application.COMAddIns("ExcelImportData")  
    Set automationObject = addIn.Object  
    automationObject.ImportData  
End Sub  
```  
  
### Accessing Objects from Non-VBA Solutions  
 In a non-VBA solution, you must cast the \<xref:Microsoft.Office.Core.COMAddIn.Object*> property value to the interface it implements, and then you can call the exposed methods on the interface object. The following code example demonstrates how to call the `ImportData` method from a different VSTO Add-in that was created by using the Office developer tools in Visual Studio.  
  
```vb#  
Dim addIn As Office.COMAddIn = Globals.ThisAddIn.Application.COMAddIns.Item("ExcelImportData")  
Dim utilities As ExcelImportData.IAddInUtilities = TryCast( _  
    addIn.Object, ExcelImportData.IAddInUtilities)  
utilities.ImportData()  
```  
  
```c#  
object addInName = "ExcelImportData";  
Office.COMAddIn addIn = Globals.ThisAddIn.Application.COMAddIns.Item(ref addInName);  
ExcelImportData.IAddInUtilities utilities = (ExcelImportData.IAddInUtilities)addIn.Object;  
utilities.ImportData();  
```  
  
 In this example, if you try to cast the value of the \<xref:Microsoft.Office.Core.COMAddIn.Object*> property to the `AddInUtilities` class rather than the `IAddInUtilities` interface, the code will throw an \<xref:System.InvalidCastException>.  
  
## See Also  
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Walkthrough: Calling Code in a VSTO Add-in from VBA](../VS_officedev/walkthrough--calling-code-in-a-vsto-add-in-from-vba.md)   
 [Developing Office Solutions](../VS_officedev/developing-office-solutions.md)   
 [How to: Create Office Projects in Visual Studio](../VS_officedev/how-to--create-office-projects-in-visual-studio.md)   
 [Architecture of VSTO Add-ins](../VS_officedev/architecture-of-vsto-add-ins.md)   
 [Customizing UI Features By Using Extensibility Interfaces](../VS_officedev/customizing-ui-features-by-using-extensibility-interfaces.md)  
  
  