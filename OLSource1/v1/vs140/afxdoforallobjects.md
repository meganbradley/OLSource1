---
title: "AfxDoForAllObjects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX/AfxDoForAllObjects"
  - "AfxDoForAllObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxDoForAllObjects function"
ms.assetid: ef4ebe96-d254-4a9b-9dbb-6b8c760a6d80
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxDoForAllObjects
Executes the specified iteration function for all objects derived from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that have been allocated with **new**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to an iteration function to execute for each object. The function arguments are a pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and a void pointer to extra data that the caller supplies to the function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to optional data that the caller can supply to the iteration function. This pointer can be **NULL**.  
  
## Remarks  
 Stack, global, or embedded objects are not enumerated. The pointer passed to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is passed to the specified iteration function each time it is called.  
  
> [!NOTE]
>  This function works only in the Debug version of MFC.  
  
## Example  
 [!code[NVC_MFCCollections#115](../vs140/codesnippet/CPP/afxdoforallobjects_1.cpp)]  
  
 [!code[NVC_MFCCollections#116](../vs140/codesnippet/CPP/afxdoforallobjects_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)