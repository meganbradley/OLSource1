---
title: "CException::CException"
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
  - "CException.CException"
  - "CException::CException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CException class, constructor"
ms.assetid: a71d3efa-6483-4201-8ba5-99732c3f23ee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CException::CException
This member function constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *b_AutoDelete*  
 Specify **TRUE** if the memory for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has been allocated on the heap. This will cause the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be deleted when the **Delete** member function is called to delete the exception. Specify **FALSE** if the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is on the stack or is a global object. In this case, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object will not be deleted when the **Delete** member function is called.  
  
## Remarks  
 You would normally never need to call this constructor directly. A function that throws an exception should create an instance of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class and call its constructor, or it should use one of the MFC throw functions, such as [AfxThrowFileException](../vs140/afxthrowfileexception.md), to throw a predefined type. This documentation is provided only for completeness.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CException Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)