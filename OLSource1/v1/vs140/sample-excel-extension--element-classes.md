---
title: "Sample Excel Extension: Element Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7c251098-00aa-49cf-9e37-5717c0c6b3f1
caps.latest.revision: 13
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Excel Extension: Element Classes
The extension uses classes that are derived from \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement*> and represent the Worksheet control and Cell control in [!INCLUDE[ofprexcel](../vs140/includes/ofprexcel_md.md)].  
  
 The base element for this extension is the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class and the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class inherit from that element  
  
## Element and ElementInformation Classes  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the base class for all user interface elements for the Excel extension, and it inherits from the \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement*> class. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the base class for the element information classes in the sample, and it has no members.  
  
#### Simple Properties and Methods  
 These members return simple values, such as the value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> property or the value of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> property, and the code is clear and easy to read. Some values are returned by using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class, which is discussed later. Others return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> because they are not relevant in this sample extension. Two members are more interesting than the others: the \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId*> property and the \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.CacheProperties*> method.  
  
#### QueryId Property  
 This property returns a condition that is made of property name-value pairs that uniquely identify the control during playback. For each derived control class, the developer must override this property to return an \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement*> object that the framework can use to find the control in the UI.  
  
#### CacheProperties Method  
 This method is called by the testing framework during the recording process to tell the element to save a snapshot of important properties. This keeps the properties available even when the actual UI control is no longer on the screen.  
  
## WorksheetElement and WorksheetInformation Classes  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class represents an Excel Worksheet in the testing framework, and inherits from the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> base class. Three properties are overridden to provide specific information about the Excel Worksheet object: \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.ClassName*>, \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.ControlTypeName*>, and \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.Name*>.  
  
 The \<xref:System.Runtime.InteropServices.ComVisibleAttribute*> is also applied to this class to make it visible to COM.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class represents information about an Excel Worksheet. It has only one member, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property, which is sufficient for this sample.  
  
## CellElement and CellInformation Classes  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class represents an Excel Cell, and inherits from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> base class. The only overridden member is the \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement.QueryId*> property, which returns an \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement*> that uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> properties to identify the cell.  
  
## Utilities and ExcelUtilities Classes  
 The internal <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class provides some constant values, such as the technology name, and a method that determines if the provided window handle represents an Excel worksheet.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class has helper methods that return a variety of information about the UI. Some methods use direct calls into external system DLLs, such as **USER32.DLL** and **OLEACC.DLL**, to get window handles from the UI**.**  
  
## See Also  
 \<xref:System.Runtime.InteropServices.ComVisibleAttribute*>   
 \<xref:Microsoft.VisualStudio.TestTools.UITest.Extension.IQueryElement*>   
 [Creating a Coded UI Extension to Support Excel](../vs140/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)