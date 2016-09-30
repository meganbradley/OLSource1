---
title: "My.WebServices Object"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "My.WebServices"
  - "My.MyProject.WebServices"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.WebServices object"
ms.assetid: f188dc05-2c75-41b6-bb68-122d1c3110a2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# My.WebServices Object
Provides properties for creating and accessing a single instance of each XML Web service referenced by the current project.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object provides an instance of each Web service referenced by the current project. Each instance is instantiated on demand. You can access these Web services through the properties of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. The name of the property is the same as the name of the Web service that the property accesses. Any class that inherits from \<xref:System.Web.Services.Protocols.SoapHttpClientProtocol*> is a Web service. For information about adding Web services to a project, see [Accessing Application Web Services](../vs140/accessing-application-web-services--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object exposes only the Web services associated with the current project. It does not provide access to Web services declared in referenced DLLs. To access a Web service that a DLL provides, you must use the qualified name of the Web service, in the form *DllName*.*WebServiceName*. For more information, see [Accessing Application Web Services](../vs140/accessing-application-web-services--visual-basic-.md).  
  
 The object and its properties are not available for Web applications.  
  
## Properties  
 Each property of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object provides access to an instance of a Web service referenced by the current project. The name of the property is the same as the name of the Web service that the property accesses, and the property type is the same as the Web service's type.  
  
> [!NOTE]
>  If there is a name collision, the property name for accessing a Web service is *RootNamespace*_*Namespace*\_*ServiceName*. For example, consider two Web services named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If one of these services is in the root namespace <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and in the namespace <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you would access that service by using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 When you first access one of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object's properties, it creates a new instance of the Web service and stores it. Subsequent accesses of that property return that instance of the Web service.  
  
 You can dispose of a Web service by assigning <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to the property for that Web service. The property setter assigns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to the stored value. If you assign any value other than <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to the property, the setter throws an \<xref:System.ArgumentException*> exception.  
  
 You can test whether a property of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object stores an instance of the Web service by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operator. You can use those operators to check if the value of the property is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Typically, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> operator has to read the value of the property to perform the comparison. However, if the property currently stores <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the property creates a new instance of the Web service and then returns that instance. However, the Visual Basic compiler treats the properties of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object specially, and allows the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator to check the status of the property without altering its value.  
  
## Example  
 This example calls the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> XML Web service, and returns the result.  
  
 [!code[VbVbalrMyWebService#1](../vs140/codesnippet/VisualBasic/my.webservices-object_1.vb)]  
  
 For this example to work, your project must reference a Web service named <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and that Web service must expose the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method. For more information, see [Accessing Application Web Services](../vs140/accessing-application-web-services--visual-basic-.md).  
  
 This code does not work in a Web application project.  
  
## Requirements  
  
### Availability by Project Type  
  
|||  
|-|-|  
|Project type|Available|  
|Windows Application|**Yes**|  
|Class Library|**Yes**|  
|Console Application|**Yes**|  
|Windows Control Library|**Yes**|  
|Web Control Library|**Yes**|  
|Windows Service|**Yes**|  
|Web Site|No|  
  
## See Also  
 \<xref:System.Web.Services.Protocols.SoapHttpClientProtocol*>   
 \<xref:System.ArgumentException*>   
 [Accessing Application Web Services](../vs140/accessing-application-web-services--visual-basic-.md)