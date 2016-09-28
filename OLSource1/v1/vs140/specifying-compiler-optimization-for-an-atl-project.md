---
title: "Specifying Compiler Optimization for an ATL Project"
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
  - "vc.appwiz.ATL.optimization"
  - "vc.appwiz.ATL.vtable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_DISABLE_NO_VTABLE macro"
  - "ATL projects, compiler optimization"
  - "ATL_NO_VTABLE macro"
ms.assetid: 7f379318-66d5-43dd-a53d-530758d3a228
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying Compiler Optimization for an ATL Project
By default, the [ATL Control Wizard](../vs140/atl-control-wizard.md) generates new classes with the ATL_NO_VTABLE macro, as follows:  
  
```  
class ATL_NO_VTABLE CProjName  
{  
   ...  
};  
```  
  
 ATL then defines _ATL_NO_VTABLE as follows:  
  
```  
#ifdef _ATL_DISABLE_NO_VTABLE  
   #define ATL_NO_VTABLE  
#else  
   #define ATL_NO_VTABLE __declspec(novtable)  
#endif  
```  
  
 If you do not define _ATL_DISABLE_NO_VTABLE, the ATL_NO_VTABLE macro expands to `declspec(novtable)`. Using `declspec(novtable)`in a class declaration prevents the vtable pointer from being initialized in the class constructor and destructor. When you build your project, the linker eliminates the vtable and all functions to which the vtable points.  
  
 You must use ATL_NO_VTABLE, and consequently `declspec(novtable)`, with only base classes that are not directly creatable. You must not use `declspec(novtable)` with the most-derived class in your project, because this class (usually [CComObject](../vs140/ccomobject-class.md), [CComAggObject](../vs140/ccomaggobject-class.md), or [CComPolyObject](../vs140/ccompolyobject-class.md)) initializes the vtable pointer for your project.  
  
 You must not call virtual functions from the constructor of any object that uses `declspec(novtable)`. You should move those calls to the [FinalConstruct](../vs140/ccomobjectrootex--finalconstruct.md) method.  
  
 If you are unsure whether you should use the `declspec(novtable)` modifier, you can remove the ATL_NO_VTABLE macro from any class definition, or you can globally disable it by specifying  
  
```  
#define _ATL_DISABLE_NO_VTABLE  
```  
  
 in stdafx.h, before all other ATL header files are included.  
  
## See Also  
 [ATL Project Wizard](../vs140/atl-project-wizard.md)   
 [Visual C++ Project Types](../vs140/visual-c---project-types.md)   
 [Creating Desktop Projects By Using Application Wizards](../vs140/creating-desktop-projects-by-using-application-wizards.md)   
 [Programming with ATL and C Run-Time Code](../vs140/programming-with-atl-and-c-run-time-code.md)   
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [novtable](../vs140/novtable.md)   
 [Default ATL Project Configurations](../vs140/default-atl-project-configurations.md)