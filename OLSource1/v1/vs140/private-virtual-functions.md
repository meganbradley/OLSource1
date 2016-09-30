---
title: "Private Virtual Functions"
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
  - "virtual functions, private"
  - "derived classes, virtual functions"
  - "access modifiers [C++], for class members"
  - "member access [C++], virtual members"
ms.assetid: 04448086-bf72-44be-9c1f-dfda1744949e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Private Virtual Functions
The way private virtual functions are handled in derived classes has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In Managed Extensions, the access level of a virtual function does not constrain its ability to be overridden within a derived class. In the new syntax, a virtual function cannot override a base class virtual function that it cannot access. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 There is no real mapping of this sort of design onto the new syntax. One simply has to make the base class members accessible – that is, non-private. The inherited methods do not have to bear the same access. In this example, the least invasive change is to make the MyBaseClass member <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This way the general program's access to the method through MyBaseClass is still prohibited.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Note that the absence of the explicit <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword in the base class, under the new syntax, generates a warning message.  
  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)   
 [Member Visibility](../vs140/member-visibility.md)