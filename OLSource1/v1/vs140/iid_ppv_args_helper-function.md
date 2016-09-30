---
title: "IID_PPV_ARGS_Helper Function"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "client/IID_PPV_ARGS_Helper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IID_PPV_ARGS_Helper function"
ms.assetid: afee9b23-8df1-4575-903f-e9ba748418f0
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IID_PPV_ARGS_Helper Function
Verifies that the type of the specified argument derives from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
> [!IMPORTANT]
>  This template specialization supports the WRL infrastructure and is not intended to be used directly from your code. Use [IID_PPV_ARGS](http://msdn.microsoft.com/library/windows/desktop/ee330727.aspx) instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of argument <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A doubly-indirect pointer.  
  
## Return Value  
 Argument <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cast to a pointer-to-a-pointer to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 A compile-time error is generated if the template parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> doesn't derive from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** client.h  
  
## See Also  
 [Reference (Windows Runtime Library)](assetId:///00000000-0000-0000-0000-000000000000)