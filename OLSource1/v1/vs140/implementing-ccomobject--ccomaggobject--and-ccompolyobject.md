---
title: "Implementing CComObject, CComAggObject, and CComPolyObject"
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
  - "CComPolyObject"
  - "CComAggObject"
  - "CComObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComPolyObject class, implementing"
  - "CreateInstance method"
  - "CComAggObject class"
  - "CComObject class, implementing"
ms.assetid: 5aabe938-104d-492e-9c41-9f7fb1c62098
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing CComObject, CComAggObject, and CComPolyObject
The template classes [CComObject](../vs140/ccomobject-class.md), [CComAggObject](../vs140/ccomaggobject-class.md), and [CComPolyObject](../vs140/ccompolyobject-class.md) are always the most derived classes in the inheritance chain. It is their responsibility to handle all of the methods in **IUnknown**: <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and **Release**. In addition, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (when used for aggregated objects) provide the special reference counting and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> semantics required for the inner unknown.  
  
 Whether <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used depends on whether you declare one (or none) of the following macros:  
  
|Macro|Effect|  
|-----------|------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Always uses <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Uses <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the object is aggregated and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if it is not. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> contains this macro so if none of the **DECLARE_\*_AGGREGATABLE** macros are declared in your class, this will be the default.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Always uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Returns an error if the object is not aggregated.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|ATL creates an instance of **CComPolyObject\<CYourClass>** when **IClassFactory::CreateInstance** is called. During creation, the value of the outer unknown is checked. If it is **NULL**, **IUnknown** is implemented for a nonaggregated object. If the outer unknown is not **NULL**, **IUnknown** is implemented for an aggregated object.|  
  
 The advantage of using <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is that the implementation of **IUnknown** is optimized for the kind of object being created. For instance, a nonaggregated object only needs a reference count, while an aggregated object needs both a reference count for the inner unknown and a pointer to the outer unknown.  
  
 The advantage of using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is that you avoid having both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in your module to handle the aggregated and nonaggregated cases. A single <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object handles both cases. This means only one copy of the vtable and one copy of the functions exist in your module. If your vtable is large, this can substantially decrease your module size. However, if your vtable is small, using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can result in a slightly larger module size because it is not optimized for an aggregated or nonaggregated object, as are <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## See Also  
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)