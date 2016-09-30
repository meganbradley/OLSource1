---
title: "is_pod Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.tr1.is_pod"
  - "is_pod"
  - "std::tr1::is_pod"
  - "std.is_pod"
  - "std::is_pod"
  - "type_traits/std::is_pod"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_pod class [TR1]"
  - "is_pod"
ms.assetid: d73ebdee-746b-4082-9fa4-2db71432eb0e
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_pod Class
Tests if type is POD.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is Plain Old Data (POD). Otherwise it is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Arithmetic types, enumeration types, pointer types, and pointer to member types are POD.  
  
 A cv-qualified version of a POD type is itself a POD type.  
  
 An array of POD is itself POD.  
  
 A struct or union, all of whose non-static data members are POD, is itself POD if it has:  
  
-   No user-declared constructors.  
  
-   No private or protected non-static data members.  
  
-   No base classes.  
  
-   No virtual functions.  
  
-   No non-static data members of reference type.  
  
-   No user-defined copy assignment operator.  
  
-   No user-defined destructor.  
  
 Therefore, you can recursively build POD structs and arrays that contain POD structs and arrays.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)