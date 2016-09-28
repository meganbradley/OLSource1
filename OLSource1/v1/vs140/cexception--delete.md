---
title: "CException::Delete"
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
  - "CException.Delete"
  - "CException::Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
  - "CException class, operations"
ms.assetid: c0331586-4bf6-4ea3-86ca-3d999b6c6c58
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CException::Delete
This function checks to see if the **CException** object was created on the heap, and if so, it calls the **delete** operator on the object.  
  
## Syntax  
  
```  
  
void Delete( );  
  
```  
  
## Remarks  
 When deleting a **CException** object, use the **Delete** member function to delete the exception. Do not use the **delete** operator directly, because the `CException` object may be a global object or have been created on the stack.  
  
 You can specify whether the object should be deleted when the object is constructed. For more information, see [CException::CException](../vs140/cexception--cexception.md).  
  
 You only need to call **Delete** if you are using the C++ **try**-**catch** mechanism. If you are using the MFC macros **TRY** and **CATCH**, then these macros will automatically call this function.  
  
## Example  
 [!code[NVC_MFCExceptions#21](../vs140/codesnippet/CPP/cexception--delete_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CException Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)