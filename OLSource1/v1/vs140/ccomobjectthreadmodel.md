---
title: "CComObjectThreadModel"
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
  - "ATLBASE/CComObjectThreadModel"
  - "CComObjectThreadModel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectThreadModel method"
ms.assetid: 69f1e800-c802-4068-9f37-75d59bfc4595
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectThreadModel
Calls the appropriate thread model methods, regardless of the threading model being used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Depending on the threading model used by your application, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> name <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> references either [CComSingleThreadModel](../vs140/ccomsinglethreadmodel-class.md) or [CComMultiThreadModel](../vs140/ccommultithreadmodel-class.md). These classes provide additional <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> names to reference a critical section class.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not reference class [CComMultiThreadModelNoCS](../vs140/ccommultithreadmodelnocs-class.md).  
  
 Using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> frees you from specifying a particular threading model class. Regardless of the threading model being used, the appropriate methods will be called.  
  
 In addition to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, ATL provides the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> name [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md). The class referenced by each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> depends on the threading model used, as shown in the following table:  
  
|typedef|Single threading|Apartment threading|Free threading|  
|-------------|----------------------|-------------------------|--------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|S|S|M|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|S|M|M|  
  
 S=<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; M=<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 Use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> within a single object class. Use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in an object that is either globally available to your program, or when you want to protect module resources across multiple threads.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Typedefs](../vs140/atl-typedefs.md)