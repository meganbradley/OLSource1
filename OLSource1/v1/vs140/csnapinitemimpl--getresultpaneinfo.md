---
title: "CSnapInItemImpl::GetResultPaneInfo"
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
  - "CSnapInItemImpl::GetResultPaneInfo"
  - "CSnapInItemImpl.GetResultPaneInfo"
  - "GetResultPaneInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetResultPaneInfo method"
ms.assetid: 7c68bb6c-5fb2-4084-b8e6-41041a356db5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::GetResultPaneInfo
Call this function to retrieve the **RESULTDATAITEM** structure of the snap-in.  
  
## Syntax  
  
```  
  
      GetResultPaneInfo (  
   RESULTDATAITEM *pResultDataItem   
);  
```  
  
#### Parameters  
 *pResultDataItem*  
 [out] A pointer to the **RESULTDATAITEM** structure of the `CSnapInItemImpl` object.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)