---
title: "collate_byname Class"
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
  - "std::collate_byname"
  - "locale/std::collate_byname"
  - "std.collate_byname"
  - "collate_byname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collate_byname class"
ms.assetid: 3dc380df-867c-4763-b60e-ba62a8e63ca7
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate_byname Class
A derived template class that describes an object that can serve as a collate facet of a given locale, enabling the retrieval of information specific to a cultural area concerning string sorting conventions.  
  
## Syntax  
  
```  
template<Class CharType>  
    class collate_byname : public collate<CharType> {  
public:  
    explicit collate_byname(  
        const char* _Locname,  
        size_t _Refs = 0  
    );  
    explicit collate_byname(  
        const string& _Locname,  
        size_t _Refs = 0);  
protected:  
    virtual ~collate_byname( );  
};  
```  
  
#### Parameters  
 `_Locname`  
 A named locale.  
  
 `_Refs`  
 An initial reference count.  
  
## Remarks  
 The template class describes an object that can serve as a [locale facet](../vs140/locale-class.md#facet_class) of type [collate](../vs140/collate-class.md#collate__collate)\<CharType>. Its behavior is determined by the [named](../vs140/locale-class.md#locale__name) locale `_Locname`. Each constructor initializes its base object with [collate](../vs140/collate-class.md#collate__collate)\<CharType>( `_Refs`).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)