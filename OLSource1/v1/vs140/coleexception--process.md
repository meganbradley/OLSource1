---
title: "COleException::Process"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleException::Process"
  - "COleException.Process"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Process method"
  - "COleException class, operations"
ms.assetid: ada95e01-2f9c-4169-9cc2-c5c1b9e769b3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleException::Process
Call the **Process** member function to translate a caught exception into an OLE status code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pAnyException*  
 Pointer to a caught exception.  
  
## Return Value  
 An OLE status code.  
  
## Remarks  
  
> [!NOTE]
>  This function is **static**.  
  
 For more information on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleException Class](../vs140/coleexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CException Class](../vs140/cexception-class.md)