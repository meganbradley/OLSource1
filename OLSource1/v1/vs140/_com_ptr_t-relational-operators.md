---
title: "_com_ptr_t Relational Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_ptr_t::operator>"
  - "_com_ptr_t::operator>="
  - "_com_ptr_t.operator<="
  - "_com_ptr_t.operator!="
  - "_com_ptr_t::operator<="
  - "_com_ptr_t.operator>"
  - "_com_ptr_t.operator<"
  - "_com_ptr_t.operator=="
  - "_com_ptr_t::operator=="
  - "_com_ptr_t.operator>="
  - "_com_ptr_t::operator!="
  - "_com_ptr_t::operator<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator, comparing specific objects"
  - "!= operator"
  - "operator >, pointers"
  - "operator>=, pointers"
  - "operator <, pointers"
  - "operator!=, relational operators"
  - "< operator, comparing specific objects"
  - "operator==, pointers"
  - "operator ==, pointers"
  - "<= operator, with specific objects"
  - "relational operators, _com_ptr_t class"
  - "operator >=, pointers"
  - "operator !=, relational operators"
  - "operator <=, pointers"
  - "> operator, comparing specific objects"
  - "operator<=, pointers"
  - "operator<, pointers"
  - "== operator, with specific Visual C++ objects"
ms.assetid: 5ae4028c-33ee-485d-bbda-88d2604d6d4b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t Relational Operators
**Microsoft Specific**  
  
 Compare the smart pointer object to another smart pointer, raw interface pointer, or **NULL**.  
  
## Syntax  
  
```  
  
      template<typename _OtherIID>   
bool operator==(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>    
bool operator==(   
   _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator==(   
   _InterfaceType* p   
);  
  
template<>   
bool operator==(   
   Interface* p   
);  
  
template<>   
bool operator==(   
   const _com_ptr_t& p   
) throw();  
  
template<>   
bool operator==(   
   _com_ptr_t& p   
) throw();  
  
bool operator==(   
   int null   
);  
```  
  
```  
  
      template<typename _OtherIID>   
bool operator!=(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>   
bool operator!=(   
   _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator!=(   
   _InterfaceType* p   
);  
  
bool operator!=(   
   int null   
);  
```  
  
```  
  
      template<typename _OtherIID>   
bool operator<(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>   
bool operator<(   
   _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator<(   
   _InterfaceType* p   
);  
```  
  
```  
  
      template<typename _OtherIID>   
bool operator>(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>   
bool operator>(_com_ptr_t<   
   _OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator>(   
   _InterfaceType* p   
);  
```  
  
```  
  
      template<typename _OtherIID>   
bool operator<=(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>   
bool operator<=(   
   _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator<=(   
   _InterfaceType* p   
);  
```  
  
```  
  
      template<typename _OtherIID>   
bool operator>=(   
   const _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _OtherIID>   
bool operator>=(   
   _com_ptr_t<_OtherIID>& p   
);  
  
template<typename _InterfaceType>   
bool operator>=(   
   _InterfaceType* p   
);  
```  
  
## Remarks  
 Compares a smart pointer object to another smart pointer, raw interface pointer, or **NULL**. Except for the **NULL** pointer tests, these operators first query both pointers for **IUnknown**, and compare the results.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)