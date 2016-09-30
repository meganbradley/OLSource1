---
title: "CSingleLock::CSingleLock"
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
  - "CSingleLock.CSingleLock"
  - "CSingleLock::CSingleLock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSingleLock class, constructor"
ms.assetid: a3f9f9d4-d508-4080-8f90-d930f7cb7b72
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSingleLock::CSingleLock
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the synchronization object to be accessed. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether to initially attempt to access the supplied object.  
  
## Remarks  
 This function is generally called from within an access member function of the controlled resource.  
  
## Example  
 [!code[NVC_MFC_Utilities#19](../vs140/codesnippet/CPP/csinglelock--csinglelock_1.h)]  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSingleLock Class](../vs140/csinglelock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)