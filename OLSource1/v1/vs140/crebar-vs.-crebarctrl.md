---
title: "CReBar vs. CReBarCtrl"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CReBar
  - CReBarCtrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - CReBar class, vs. CReBarCtrl
  - rebar controls, CReBarCtrl class
  - GetReBarCtrl class
ms.assetid: 7f9c1d7e-5d5f-4956-843c-69ed3df688d0
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CReBar vs. CReBarCtrl
MFC provides two classes to create rebars: [CReBar](../vs140/crebar-class.md) and [CReBarCtrl](../vs140/crebarctrl-class.md) (which wraps the Windows common control API). **CReBar** provides all of the functionality of the rebar common control, and it handles many of the required common control settings and structures for you.  
  
 `CReBarCtrl` is a wrapper class for the Win32 rebar control, and therefore may be easier to implement if you do not intend to integrate the rebar into the MFC architecture. If you plan to use `CReBarCtrl` and integrate the rebar into the MFC architecture, you must take additional care to communicate rebar control manipulations to MFC. This communication is not difficult; however, it is additional work that is unneeded when you use **CReBar**.  
  
 Visual C++ provides two ways to take advantage of the rebar common control.  
  
-   Create the rebar using **CReBar**, and then call [CReBar::GetReBarCtrl](../vs140/crebar--getrebarctrl.md) to get access to the `CReBarCtrl` member functions.  
  
    > [!NOTE]
    >  `CReBar::GetReBarCtrl` is an inline member function that casts the **this** pointer of the rebar object. This means that, at run time, the function call has no overhead.  
  
-   Create the rebar using [CReBarCtrl](../vs140/crebarctrl-class.md)'s constructor.  
  
 Either method will give you access to the member functions of the rebar control. When you call `CReBar::GetReBarCtrl`, it returns a reference to a `CReBarCtrl` object so you can use either set of member functions. See [CReBar](../vs140/crebar-class.md) for information on constructing and creating a rebar using **CReBar**.  
  
## See Also  
 [Using CReBarCtrl](../vs140/using-crebarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)