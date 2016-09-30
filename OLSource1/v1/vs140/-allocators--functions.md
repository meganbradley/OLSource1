---
title: "&lt;allocators&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9cb5ee07-1ff9-4594-ae32-3c8c6efb511a
caps.latest.revision: 14
---
# &lt;allocators&gt; functions
||||  
|-|-|-|  
|[ALLOCATOR_DECL](#allocator_decl)|[CACHE_CHUNKLIST](#cache_chunklist)|[CACHE_FREELIST](#cache_freelist)|  
|[CACHE_SUBALLOC](#cache_suballoc)|[SYNC_DEFAULT](#sync_default)|  
  
##  \<a name="allocator_decl">\</a>  ALLOCATOR_DECL  
 Yields an allocator template class.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The macro yields a template definition <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and a specialization <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> which together define an allocator template class that uses the synchronization filter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and a cache of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 For compilers that can compile rebind, the resulting template definition looks like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For compilers that cannot compile rebind the resulting template definition looks like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cache_chunklist">\</a>  CACHE_CHUNKLIST  
 Yields <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cache_freelist">\</a>  CACHE_FREELIST  
 Yields <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cache_suballoc">\</a>  CACHE_SUBALLOC  
 Yields <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="sync_default">\</a>  SYNC_DEFAULT  
 Yields a synchronization filter.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If a compiler supports compiling both single-threaded and multi-threaded applications, for single-threaded applications the macro yields <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; in all other cases it yields <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;allocators&gt;](../vs140/-allocators-.md)