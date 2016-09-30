---
title: "CMFCVisualManager::GetInstance"
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
  - "CMFCVisualManager::GetInstance"
  - "CMFCVisualManager.GetInstance"
  - "GetInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInstance method"
ms.assetid: b77e6cb7-bf84-47ef-9c38-8b8eb993dda2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetInstance
Returns a pointer to the current [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md) object for the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 An application can only have one <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object associated with it. This includes any object derived from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. This method returns a pointer to the associated <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. If the application does not have an associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, this method will create one and associate it with the application.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)