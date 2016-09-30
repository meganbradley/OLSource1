---
title: "accelerator::accelerator Constructor"
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
  - "amprt/Concurrency::accelerator::accelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accelerator, constructor"
ms.assetid: 6c560bd9-7fc0-4b19-a55a-4d8d6b6f686d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::accelerator Constructor
Initializes a new instance of the [accelerator class](../vs140/accelerator-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The path of the physical device.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The accelerator to copy.  
  
## Overload List  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class. The new instance represents the default accelerator, usually  the fastest accelerator available. This constructor is equivalent the constructor <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. The new instance represents the physical device specified in the path argument. The path can be any one of the following:\<br />\<br /> [accelerator::default_accelerator Data Member](../vs140/accelerator--default_accelerator-data-member.md) or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which represents the path of the fastest accelerator available, as chosen by the runtime.\<br />\<br /> [accelerator::direct3d_warp Data Member](../vs140/accelerator--direct3d_warp-data-member.md) or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which represents the WARP accelerator.\<br />\<br /> [accelerator::direct3d_ref Data Member](../vs140/accelerator--direct3d_ref-data-member.md) or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which represents the REF accelerator.\<br />\<br /> A device path that uniquely identifies a hardware accelerator that is available on the host system.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Initializes a new instance of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class. The new instance is a copy of another <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object. This constructor performs a shallow copy. The new <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object points to the same underlying device that is specified in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.|  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)