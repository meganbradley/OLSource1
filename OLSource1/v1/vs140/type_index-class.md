---
title: "type_index Class"
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
  - "typeindex/std::type_index"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "type_index class"
ms.assetid: db366119-74cb-43e8-aacf-9679e561fa2f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# type_index Class
The `type_index` class wraps a pointer to [type_info](../vs140/type_info-class.md) to assist in indexing by such objects.  
  
```  
class type_index {  
public:  
    type_index(const type_info& tinfo);  
    const char *name() const;  
    size_t hash_code() const;  
    bool operator==(const type_info& right) const;  
    bool operator!=(const type_info& right) const;  
    bool operator<(const type_info& right) const;  
    bool operator<=(const type_info& right) const;  
    bool operator>(const type_info& right) const;  
    bool operator>=(const type_info& right) const;  
};  
```  
  
 The constructor initializes `ptr` to `&tinfo`.  
  
 `name` returns `ptr->name()`.  
  
 `hash_code` returns `ptr->hash_code().`  
  
 `operator==` returns `*ptr == right.ptr`.  
  
 `operator!=` returns `!(*this == right)`.  
  
 `operator<` returns `*ptr->before(*right.ptr)`.  
  
 `operator<=` returns `!(right < *this).`  
  
 `operator>` returns `right < *this`.  
  
 `operator>=` returns `!(*this < right)`.  
  
## See Also  
 [Run-Time Type Information](../vs140/run-time-type-information.md)   
 [\<typeindex>](../vs140/-typeindex-.md)