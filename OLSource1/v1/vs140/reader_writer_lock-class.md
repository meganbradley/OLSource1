---
title: "reader_writer_lock Class"
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
  - "concrt/concurrency::reader_writer_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reader_writer_lock class"
ms.assetid: 91a59cd2-ca05-4b74-8398-d826d9f86736
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reader_writer_lock Class
A writer-preference queue-based reader-writer lock with local only spinning. The lock grants first in - first out (FIFO) access to writers and starves readers under a continuous load of writers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Classes  
  
|Name|Description|  
|----------|-----------------|  
|[reader_writer_lock::scoped_lock Class](#reader_writer_lock__scoped_lock_class)|An exception safe RAII wrapper that can be used to acquire                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> lock objects as a writer.|  
|[reader_writer_lock::scoped_lock_read Class](#reader_writer_lock__scoped_lock_read_class)|An exception safe RAII wrapper that can be used to acquire                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> lock objects as a reader.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[reader_writer_lock::reader_writer_lock Constructor](#reader_writer_lock__reader_writer_lock_constructor)|Constructs a new                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[reader_writer_lock::~reader_writer_lock Destructor](#reader_writer_lock___dtorreader_writer_lock_destructor)|Destroys the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[reader_writer_lock::lock Method](#reader_writer_lock__lock_method)|Acquires the reader-writer lock as a writer.|  
|[reader_writer_lock::lock_read Method](#reader_writer_lock__lock_read_method)|Acquires the reader-writer lock as a reader. If there are writers, active readers have to wait until they are done. The reader simply registers an interest in the lock and waits for writers to release it.|  
|[reader_writer_lock::try_lock Method](#reader_writer_lock__try_lock_method)|Attempts to acquire the reader-writer lock as a writer without blocking.|  
|[reader_writer_lock::try_lock_read Method](#reader_writer_lock__try_lock_read_method)|Attempts to acquire the reader-writer lock as a reader without blocking.|  
|[reader_writer_lock::unlock Method](#reader_writer_lock__unlock_method)|Unlocks the reader-writer lock based on who locked it, reader or writer.|  
  
## Remarks  
 For more information, see                 [Synchronization Data Structures](../vs140/synchronization-data-structures.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="reader_writer_lock__lock_method">\</a>  reader_writer_lock::lock Method  
 Acquires the reader-writer lock as a writer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 It is often safer to utilize the                         [scoped_lock](#reader_writer_lock__scoped_lock_class) construct to acquire and release a                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object as a writer in an exception safe way.  
  
 After a writer attempts to acquire the lock, any future readers will block until the writers have successfully acquired and released the lock. This lock is biased towards writers and can starve readers under a continuous load of writers.  
  
 Writers are chained so that a writer exiting the lock releases the next writer in line.  
  
 If the lock is already held by the calling context, an                         [improper_lock](../vs140/improper_lock-class.md) exception will be thrown.  
  
##  \<a name="reader_writer_lock__lock_read_method">\</a>  reader_writer_lock::lock_read Method  
 Acquires the reader-writer lock as a reader. If there are writers, active readers have to wait until they are done. The reader simply registers an interest in the lock and waits for writers to release it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 It is often safer to utilize the                         [scoped_lock_read](#reader_writer_lock__scoped_lock_read_class) construct to acquire and release a                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object as a reader in an exception safe way.  
  
 If there are writers waiting on the lock, the reader will wait until all writers in line have acquired and released the lock. This lock is biased towards writers and can starve readers under a continuous load of writers.  
  
##  \<a name="reader_writer_lock__reader_writer_lock_constructor">\</a>  reader_writer_lock::reader_writer_lock Constructor  
 Constructs a new                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="reader_writer_lock___dtorreader_writer_lock_destructor">\</a>  reader_writer_lock::~reader_writer_lock Destructor  
 Destroys the                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 It is expected that the lock is no longer held when the destructor runs. Allowing the reader writer lock to destruct with the lock still held results in undefined behavior.  
  
##  \<a name="reader_writer_lock__scoped_lock_class">\</a>  reader_writer_lock::scoped_lock Class  
 An exception safe RAII wrapper that can be used to acquire                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> lock objects as a writer.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="reader_writer_lock__scoped_lock_read_class">\</a>  reader_writer_lock::scoped_lock_read Class  
 An exception safe RAII wrapper that can be used to acquire                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> lock objects as a reader.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="reader_writer_lock__try_lock_method">\</a>  reader_writer_lock::try_lock Method  
 Attempts to acquire the reader-writer lock as a writer without blocking.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 If the lock was acquired, the value                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; otherwise, the value                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
##  \<a name="reader_writer_lock__try_lock_read_method">\</a>  reader_writer_lock::try_lock_read Method  
 Attempts to acquire the reader-writer lock as a reader without blocking.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 If the lock was acquired, the value                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; otherwise, the value                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="reader_writer_lock__unlock_method">\</a>  reader_writer_lock::unlock Method  
 Unlocks the reader-writer lock based on who locked it, reader or writer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 If there are writers waiting on the lock, the release of the lock will always go to the next writer in FIFO order. This lock is biased towards writers and can starve readers under a continuous load of writers.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [critical_section Class](../vs140/critical_section-class.md)