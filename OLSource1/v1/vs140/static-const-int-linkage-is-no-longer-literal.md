---
title: "Static Const Int Linkage Is No Longer Literal"
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
  - "literal attribute [C++]"
  - "constants, declaring"
  - "integral constant expressions"
ms.assetid: d2a5e3d2-ffb0-4b61-8114-bec5993a1195
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Static Const Int Linkage Is No Longer Literal
Declaration of a constant member of a class has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 Although `static const` integral members are still supported, their linkage attribute has changed. Their former linkage attribute is now carried in a literal integral member. For example, consider the following Managed Extensions class:  
  
```  
public __gc class Constants {  
public:  
   static const int LOG_DEBUG = 4;  
};  
```  
  
 This generates the following underlying CIL attributes for the field (note the literal attribute):  
  
```  
.field public static literal int32   
modopt([Microsoft.VisualC]Microsoft.VisualC.IsConstModifier) STANDARD_CLIENT_PRX = int32(0x00000004)  
```  
  
 While this still compiles under the new syntax:  
  
```  
public ref class Constants {  
public:  
   static const int LOG_DEBUG = 4;  
};  
```  
  
 it no longer emits the literal attribute, and therefore is not viewed as a constant by the CLR runtime:  
  
```  
.field public static int32 modopt([Microsoft.VisualC]Microsoft.VisualC.IsConstModifier) STANDARD_CLIENT_PRX = int32(0x00000004)  
```  
  
 In order to have the same inter-language literal attribute, the declaration should be changed to the newly supported `literal` data member, as follows,  
  
```  
public ref class Constants {  
public:  
   literal int LOG_DEBUG = 4;  
};  
```  
  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)   
 [literal](../vs140/literal--c---component-extensions-.md)