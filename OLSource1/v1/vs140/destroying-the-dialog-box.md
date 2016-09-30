---
title: "Destroying the Dialog Box"
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
  - "dialog boxes, deleting"
  - "destruction, dialog box"
  - "dialog boxes, destroying"
  - "dialog boxes, removing"
  - "modeless dialog boxes, destroying"
  - "MFC dialog boxes, destroying"
  - "modal dialog boxes, destroying"
ms.assetid: dabceee7-3639-4d85-bf34-73515441b3d0
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Destroying the Dialog Box
Modal dialog boxes are normally created on the stack frame and destroyed when the function that created them ends. The dialog object's destructor is called when the object goes out of scope.  
  
 Modeless dialog boxes are normally created and owned by a parent view or frame window — the application's main frame window or a document frame window. The default [OnClose](../vs140/cwnd--onclose.md) handler calls [DestroyWindow](../vs140/cwnd--destroywindow.md), which destroys the dialog-box window. If the dialog box stands alone, with no pointers to it or other special ownership semantics, you should override [PostNcDestroy](../vs140/cwnd--postncdestroy.md) to destroy the C++ dialog object. You should also override [OnCancel](../vs140/cdialog--oncancel.md) and call <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> from within it. If not, the owner of the dialog box should destroy the C++ object when it is no longer necessary.  
  
## See Also  
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)