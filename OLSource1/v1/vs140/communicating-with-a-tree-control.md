---
title: "Communicating with a Tree Control"
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
  - "tree controls, communicating with"
  - "CTreeCtrl class, calling member functions"
  - "communications, tree controls"
  - "tree controls"
ms.assetid: 680ad9ee-b11f-452d-93fa-501ca7d7e069
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Communicating with a Tree Control
You use different methods for calling member functions in a [CTreeCtrl](../vs140/ctreectrl-class.md) object depending on how the object was created:  
  
-   If the tree control is in a dialog box, use a member variable of type `CTreeCtrl` that you create in the dialog box class.  
  
-   If the tree control is a child window, use the `CTreeCtrl` object (or pointer) you used to construct the object.  
  
-   If you're using a `CTreeView` object, use the function [CTreeView::GetTreeCtrl](../vs140/ctreeview--gettreectrl.md) to get a reference to the tree control. You can initialize another reference with this value or assign the address of the reference to a `CTreeCtrl` pointer.  
  
## See Also  
 [Using CTreeCtrl](../vs140/using-ctreectrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)