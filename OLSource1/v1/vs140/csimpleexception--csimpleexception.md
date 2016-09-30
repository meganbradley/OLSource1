---
title: "CSimpleException::CSimpleException"
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
  - "CSimpleException::CSimpleException"
  - "CSimpleException.CSimpleException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleException class, constructor"
ms.assetid: 5b58a1dd-db72-4d09-8760-da4fad342539
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleException::CSimpleException
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specify **TRUE** if the memory for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has been allocated on the heap. This will cause the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be deleted when the **Delete** member function is called to delete the exception. Specify **FALSE** if the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is on the stack or is a global object. In this case, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object will not be deleted when the **Delete** member function is called.  
  
## Remarks  
 You would normally never need to call this constructor directly. A function that throws an exception should create an instance of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class and call its constructor, or it should use one of the MFC throw functions, such as [AfxThrowFileException](../vs140/afxthrowfileexception.md), to throw a predefined type.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CSimpleException Class](../vs140/csimpleexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)