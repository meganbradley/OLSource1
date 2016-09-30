---
title: "Understanding Parse Trees"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parse trees"
ms.assetid: 668ce2dd-a1c3-4ca0-8135-b25267cb6a85
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Understanding Parse Trees
You can define one or more parse trees in your registrar script, where each parse tree has the following form:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 where:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are equivalent; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are equivalent; and so on.  
  
 A parse tree can add multiple keys and subkeys to the \<root key>. In doing so, it keeps a subkey's handle open until the parser has completed parsing all of its subkeys. This approach is more efficient than operating on a single key at a time, as seen in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Here, the Registrar initially opens (creates) <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. It then sees that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has a subkey. Rather than close the key to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the Registrar retains the handle and opens (creates) <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> using this parent handle. (The system registry can be slower when no parent handle is open.) Thus, opening <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and then opening <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as the parent is faster than opening <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, closing <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and then opening <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## See Also  
 [Creating Registrar Scripts](../vs140/creating-registrar-scripts.md)