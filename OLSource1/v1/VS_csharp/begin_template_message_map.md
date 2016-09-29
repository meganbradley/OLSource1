---
title: "BEGIN_TEMPLATE_MESSAGE_MAP"
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
  - "BEGIN_TEMPLATE_MESSAGE_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_TEMPLATE_MESSAGE_MAP"
ms.assetid: 972e730b-5f7b-413b-938d-13a367db6a36
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_TEMPLATE_MESSAGE_MAP
Begins the definition of a message map on a class type containing a single template argument.  
  
## Syntax  
  
```  
  
BEGIN_TEMPLATE_MESSAGE_MAP(  
theClass  
,   
type_name  
, baseClass )  
```  
  
#### Parameters  
 `theClass`  
 Specifies the name of the class whose message map this is.  
  
 `type_name`  
 The name of the template parameter specified for the class.  
  
 `baseClass`  
 Specifies the name of the base class of `theClass`.  
  
## Remarks  
 This macro is similar to the [BEGIN_MESSAGE_MAP](../VS_csharp/begin_message_map.md) macro; however, this macro is intended for classes containing a single template argument.  
  
 In the method implementation section of your class, start the message map with the **BEGIN_TEMPLATE_MESSAGE_MAP** macro; then add macro entries for each of your message-handler methods as you would for a standard message map. As with the **BEGIN_MESSAGE_MAP** macro, complete the template message map with the [END_MESSAGE_MAP](../VS_csharp/end_message_map.md) macro.  
  
 For more information on implementing message maps for template classes, refer to [How to: Create a Message Map for a Template Class](../VS_csharp/how-to--create-a-message-map-for-a-template-class.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DECLARE_MESSAGE_MAP](../VS_csharp/declare_message_map.md)   
 [BEGIN_MESSAGE_MAP](../VS_csharp/begin_message_map.md)   
 [END_MESSAGE_MAP](../VS_csharp/end_message_map.md)