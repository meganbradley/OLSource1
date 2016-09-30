---
title: "CSnapInItemImpl::GetResultViewType"
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
  - "CSnapInItemImpl.GetResultViewType"
  - "CSnapInItemImpl::GetResultViewType"
  - "GetResultViewType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetResultViewType method"
ms.assetid: 62de7cd0-4e6f-441e-8450-b9670e138f35
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::GetResultViewType
Call this function to retrieve the type of view for the result pane of the snap-in object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *ppViewType*  
 [out] Pointer to the address of the returned view type.  
  
 *pViewOptions*  
 [out] Pointer to the **MMC_VIEW_OPTIONS** enumeration, which provides the console with options specified by the owning snap-in. This value can be one of the following:  
  
-   **MMC_VIEW_OPTIONS_NOLISTVIEWS** = 0x00000001   Tells the console to refrain from presenting standard list view choices in the **View** menu. Allows the snap-in to display its own custom views only in the result view pane. This is the only option flag defined at this time.  
  
-   **MMC_VIEW_OPTIONS_NONE** = 0   Allows the default view options.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)