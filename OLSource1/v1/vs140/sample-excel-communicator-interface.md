---
title: "Sample Excel Communicator Interface"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1dbf1090-762c-4824-82dd-2d7c2c6f00b6
caps.latest.revision: 15
ms.author: "mlearned"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sample Excel Communicator Interface
The sample <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> interface is used in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> project.  
  
## IExcelUICommunication Interface  
 This interface defines the communication points between the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which runs in the Coded UI Test process, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which runs in the [!INCLUDE[ofprexcel](../vs140/includes/ofprexcel_md.md)] process.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> assembly has a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class that derives from this interface and uses the Excel object model to process the methods.  
  
 Some methods get the requested information from Excel then create and return one of the information objects, such as the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 Other methods use a provided information object, find the corresponding control in Excel, and perform some process on the control. For example, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method scrolls the Worksheet so that the designated cell is visible.  
  
## CodedUIExtensibilitySample and ExcelCodedUIAddinHelper Communication  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> assembly runs in the Excel process and has the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class that implements the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface and gets or sets the required information directly from the Excel UI.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> assembly runs in the Visual Studio Coded UI Test process. This assembly has the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class that opens a .NET Remoting channel, and provides an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property that uses the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface to use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> assembly to pass requests and information objects, such as a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object, back and forth between the two assemblies.  
  
## See Also  
 [Extending Coded UI Testing to Microsoft Excel](../vs140/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md)   
 [Sample Excel Add-In for Coded UI Testing](../vs140/sample-excel-add-in-for-coded-ui-testing.md)   
 [Sample Coded UI Test Extension for Excel](../vs140/sample-coded-ui-test-extension-for-excel.md)