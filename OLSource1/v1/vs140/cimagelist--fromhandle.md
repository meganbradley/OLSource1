---
title: "CImageList::FromHandle"
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
  - "CImageList.FromHandle"
  - "CImageList::FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandle method [MFC]"
ms.assetid: 482db815-e383-4f87-b9db-51fe3e38ac07
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::FromHandle
Returns a pointer to a `CImageList` object when given a handle to an image list.  
  
## Syntax  
  
```  
  
      static CImageList* PASCAL FromHandle(  
   HIMAGELIST hImageList   
);  
```  
  
#### Parameters  
 `hImageList`  
 Specifies the image list.  
  
## Return Value  
 A pointer to a `CImageList` object if successful; otherwise **NULL**.  
  
## Remarks  
 If a `CImageList` is not already attached to the handle, a temporary `CImageList` object is created and attached. This temporary `CImageList` object is valid only until the next time the application has idle time in its event loop, at which time all temporary objects are deleted.  
  
## Example  
 [!code[NVC_MFC_CImageList#13](../vs140/codesnippet/CPP/cimagelist--fromhandle_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::FromHandlePermanent](../vs140/cimagelist--fromhandlepermanent.md)