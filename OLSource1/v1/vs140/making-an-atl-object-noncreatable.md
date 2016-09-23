---
title: "Making an ATL Object Noncreatable"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - vc.appwiz.ATL.objects
dev_langs: 
  - C++
helpviewer_keywords: 
  - noncreatable ATL objects
  - ATL projects, noncreatable objects
ms.assetid: 80d0bca2-dea0-4801-9a85-6243124437f6
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Making an ATL Object Noncreatable
You can change the attributes of an ATL-based COM object so that a client cannot directly create the object. In this case, the object would be returned through a method call on another object rather than created directly.  
  
### To make an object noncreatable  
  
1.  Remove the [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for the object. If you want the object to be noncreatable but the control to be registered, replace OBJECT_ENTRY_AUTO with [OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO](../vs140/object_entry_non_createable_ex_auto.md).  
  
2.  Add the [noncreatable](../vs140/noncreatable.md) attribute to the coclass in the .idl file. For example:  
  
    ```  
    [  
       uuid(A1992E3D-3CF0-11D0-826F-00A0C90F2851),  
       helpstring("MyObject"),  
      noncreatable  
    ]  
    coclass MyObject  
    {  
       [default] interface IMyInterface;  
    }  
    ```  
  
## See Also  
 [ATL Project Wizard](../vs140/atl-project-wizard.md)   
 [Visual C++ Project Types](../vs140/visual-c---project-types.md)   
 [Creating Desktop Projects By Using Application Wizards](../vs140/creating-desktop-projects-by-using-application-wizards.md)   
 [Programming with ATL and C Run-Time Code](../vs140/programming-with-atl-and-c-run-time-code.md)   
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [Default ATL Project Configurations](../vs140/default-atl-project-configurations.md)