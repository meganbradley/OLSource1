---
title: "ALLOCATOR_DECL (&lt;allocators&gt;)"
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
  - "stdext::ALLOCATOR_DECL"
  - "ALLOCATOR_DECL"
  - "stdext.ALLOCATOR_DECL"
  - "allocators/stdext::ALLOCATOR_DECL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ALLOCATOR_DECL macro"
ms.assetid: 419d0f0a-aaa8-444a-a166-0ec85c432a64
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ALLOCATOR_DECL (&lt;allocators&gt;)
Yields an allocator template class.  
  
## Syntax  
  
```  
#define ALLOCATOR_DECL(cache, sync, name) <alloc_template>  
```  
  
## Remarks  
 The macro yields a template definition `template <class Type> class name {.....}` and a specialization `template <> class name<void> {.....}` which together define an allocator template class that uses the synchronization filter `sync` and a cache of type `cache`.  
  
 For compilers that can compile rebind, the resulting template definition looks like this:  
  
```  
template <class Type> class name  
    : public stdext::allocators::allocator_base<Type, sync<cache > >  
    {  
    public:  
        name() {}  
        template <class Other> name(const name<Other>&) {}  
        template <class Other> name& operator = (const name<Other>&)  
            {return *this; }  
        template <class Other> struct rebind  
            {    /* convert a name<Type> to a name<Other> */  
            typedef name<Other> other;  
            };  
    };  
```  
  
 For compilers that cannot compile rebind the resulting template definition looks like this:  
  
```  
template <class Type< class name  
    : public stdext::allocators::allocator_base<Type,  
        sync<stdext::allocators::rts_alloc<cache > > >  
    {  
    public:  
        name() {}  
        template <class Other> name(const name<Other>&) {}  
        template <class Other> name& operator = (const name<Other>&)  
            {return *this; }  
    };  
```  
  
## Requirements  
 **Header:** <allocators\>  
  
 **Namespace:** stdext  
  
## See Also  
 [<allocators\>](../vs140/-allocators-.md)