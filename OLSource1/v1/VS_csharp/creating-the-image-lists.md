---
title: "Creating the Image Lists"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListCtrl class, creating image lists for"
  - "image lists [C++], creating for CListCtrl"
  - "lists [C++], image"
ms.assetid: c2768515-deba-49e8-a6f3-5be6482afb19
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating the Image Lists
Creating image lists is the same whether you use [CListView](../VS_csharp/clistview-class.md) or [CListCtrl](../VS_csharp/clistctrl-class.md).  
  
> [!NOTE]
>  You only need image lists if your list control includes the `LVS_ICON` style.  
  
 Use class `CImageList` to create one or more image lists (for full-size icons, small icons, and states). See [CImageList](../VS_csharp/cimagelist-class.md), and see [List View Image Lists](http://msdn.microsoft.com/library/windows/desktop/bb774736) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
 Call [CListCtrl::SetImageList](../Topic/CListCtrl::SetImageList.md) for each image list; pass a pointer to the appropriate `CImageList` object.  
  
## See Also  
 [Using CListCtrl](../VS_csharp/using-clistctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)