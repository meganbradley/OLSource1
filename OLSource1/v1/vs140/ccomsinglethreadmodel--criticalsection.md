---
title: "CComSingleThreadModel::CriticalSection"
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
  - "CComSingleThreadModel::CriticalSection"
  - "CComSingleThreadModel.CriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSection typedef"
ms.assetid: 80adef91-1ff7-4b9b-8a58-6c343cb7cd56
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSingleThreadModel::CriticalSection
When using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> references class [CComFakeCriticalSection](../vs140/ccomfakecriticalsection-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Because <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not provide a critical section, its methods do nothing.  
  
 [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md) and [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md) contain definitions for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The following table shows the relationship between the threading model class and the critical section class referenced by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>:  
  
|Class defined in|Class referenced|  
|----------------------|----------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
 In addition to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you can use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> name [AutoCriticalSection](../vs140/ccomsinglethreadmodel--autocriticalsection.md). You should not specify <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in global objects or static class members if you want to eliminate the CRT startup code.  
  
## Example  
 See [CComMultiThreadModel::AutoCriticalSection](../vs140/ccommultithreadmodel--autocriticalsection.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComSingleThreadModel Class](../vs140/ccomsinglethreadmodel-class.md)   
 [CComObjectThreadModel](../vs140/ccomobjectthreadmodel.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [CComSingleThreadModel::ThreadModelNoCS](../vs140/ccomsinglethreadmodel--threadmodelnocs.md)