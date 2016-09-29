---
title: "Destroying the List Control"
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
  - "list controls, destroying"
  - "CListCtrl class, destroying controls"
ms.assetid: 513ec820-3a02-49d2-b073-a6a7a3fc91b3
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Destroying the List Control
If you embed your [CListCtrl](../vs140/clistctrl-class.md) object as a data member of a view or dialog class, it is destroyed when its owner is destroyed. If you use a [CListView](../vs140/clistview-class.md), the framework destroys the control when it destroys the view.  
  
 If you arrange for some of your list data to be stored in the application rather than the list control, you will need to arrange for its deallocation. For more information, see [Callback Items and the Callback Mask](http://msdn.microsoft.com/library/windows/desktop/bb774736) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 In addition, you are responsible for deallocating any image lists you created and associated with the list control object.  
  
## See Also  
 [Using CListCtrl](../vs140/using-clistctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)