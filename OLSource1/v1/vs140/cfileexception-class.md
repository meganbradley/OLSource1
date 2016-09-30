---
title: "CFileException Class"
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
  - "CFileException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, exceptions of"
  - "exceptions, file type"
  - "CFileException class"
ms.assetid: f6491bb9-bfbc-42fd-a952-b33f9b62323f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException Class
Represents a file-related exception condition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFileException::CFileException](#cfileexception__cfileexception)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileException::ErrnoToException](#cfileexception__errnotoexception)|Returns cause code corresponding to a run-time error number.|  
|[CFileException::GetErrorMessage](#cfileexception__geterrormessage)|Retrieves the message describing an exception.|  
|[CFileException::OsErrorToException](#cfileexception__oserrortoexception)|Returns a cause code corresponding to an operating system error code.|  
|[CFileException::ThrowErrno](#cfileexception__throwerrno)|Throws a file exception based on a runtime error number.|  
|[CFileException::ThrowOsError](#cfileexception__throwoserror)|Throws a file exception based on an operating system error number.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFileException::m_cause](#cfileexception__m_cause)|Contains portable code corresponding to the exception cause.|  
|[CFileException::m_lOsError](#cfileexception__m_loserror)|Contains the related operating-system error number.|  
|[CFileException::m_strFileName](#cfileexception__m_strfilename)|Contains the name of the file for this exception.|  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class includes public data members that hold the portable cause code and the operating-system-specific error number. The class also provides static member functions for throwing file exceptions and for returning cause codes for both operating-system errors and C run-time errors.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects are constructed and thrown in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member functions and in member functions of derived classes. You can access these objects within the scope of a **CATCH** expression. For portability, use only the cause code to get the reason for an exception. For more information about exceptions, see the article [Exception Handling (MFC)](../vs140/exception-handling-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CException](../vs140/cexception-class.md)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cfileexception__cfileexception">\</a>  CFileException::CFileException  
 Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object that stores the cause code and the operating-system code in the object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An enumerated type variable that indicates the reason for the exception. See [CFileException::m_cause](#cfileexception__m_cause) for a list of the possible values.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An operating-system-specific reason for the exception, if available. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter provides more information than <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> does.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Points to a string containing the name of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object causing the exception.  
  
### Remarks  
 Do not use this constructor directly, but rather call the global function [AfxThrowFileException](../vs140/afxthrowfileexception.md).  
  
> [!NOTE]
>  The variable <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> applies only to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class does not handle this error code.  
  
##  \<a name="cfileexception__errnotoexception">\</a>  CFileException::ErrnoToException  
 Converts a given run-time library error value to a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> enumerated error value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 An integer error code as defined in the run-time include file ERRNO.H.  
  
### Return Value  
 Enumerated value that corresponds to a given run-time library error value.  
  
### Remarks  
 See [CFileException::m_cause](#cfileexception__m_cause) for a list of the possible enumerated values.  
  
### Example  
 [!code[NVC_MFCFiles#26](../vs140/codesnippet/CPP/cfileexception-class_1.cpp)]  
  
##  \<a name="cfileexception__geterrormessage">\</a>  CFileException::GetErrorMessage  
 Retrieves text that describes an exception.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Pointer to a buffer that receives an error message.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The maximum number of characters the specified buffer can hold. This includes the terminating null character.  
  
 [in, out] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Pointer to an unsigned integer that receives the help context ID. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, no ID is returned.  
  
### Return Value  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the specified buffer is too small, the error message is truncated.  
  
### Example  
 The following example uses <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCExceptions#22](../vs140/codesnippet/CPP/cfileexception-class_2.cpp)]  
  
##  \<a name="cfileexception__m_cause">\</a>  CFileException::m_cause  
 Contains values defined by a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> enumerated type.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This data member is a public variable of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The enumerators and their meanings are as follows:  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> 0: No error occurred.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> 1: An unspecified error occurred.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> 2: The file could not be located.  
  
-   <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> 3: All or part of the path is invalid.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> 4: The permitted number of open files was exceeded.  
  
-   <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> 5: The file could not be accessed.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> 6: There was an attempt to use an invalid file handle.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> 7: The current working directory cannot be removed.  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> 8: There are no more directory entries.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> 9: There was an error trying to set the file pointer.  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> 10: There was a hardware error.  
  
-   <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> 11: SHARE.EXE was not loaded, or a shared region was locked.  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> 12: There was an attempt to lock a region that was already locked.  
  
-   <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> 14: The disk is full.  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> 15: The end of file was reached.  
  
    > [!NOTE]
    >  These <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> cause enumerators are distinct from the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> cause enumerators.  
  
    > [!NOTE]
    >  <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is deprecated. Use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> instead. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is used in an application and built with /clr, the resulting syntax errors are not easy to decipher.  
  
### Example  
 [!code[NVC_MFCFiles#30](../vs140/codesnippet/CPP/cfileexception-class_3.cpp)]  
  
##  \<a name="cfileexception__m_loserror">\</a>  CFileException::m_lOsError  
 Contains the operating-system error code for this exception.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 See your operating-system technical manual for a listing of error codes. This data member is a public variable of type **LONG**.  
  
##  \<a name="cfileexception__m_strfilename">\</a>  CFileException::m_strFileName  
 Contains the name of the file for this exception condition.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cfileexception__oserrortoexception">\</a>  CFileException::OsErrorToException  
 Returns an enumerator that corresponds to a given <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> value. If the error code is unknown, then the function returns **CFileException::generic**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 An operating-system-specific error code.  
  
### Return Value  
 Enumerated value that corresponds to a given operating-system error value.  
  
### Example  
 [!code[NVC_MFCFiles#27](../vs140/codesnippet/CPP/cfileexception-class_4.cpp)]  
  
##  \<a name="cfileexception__throwerrno">\</a>  CFileException::ThrowErrno  
 Constructs a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object corresponding to a given <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> value, then throws the exception.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 An integer error code as defined in the run-time include file ERRNO.H.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to the string containing the name of the file that caused the exception, if available.  
  
### Example  
 [!code[NVC_MFCFiles#28](../vs140/codesnippet/CPP/cfileexception-class_5.cpp)]  
  
##  \<a name="cfileexception__throwoserror">\</a>  CFileException::ThrowOsError  
 Throws a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> corresponding to a given <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> value. If the error code is unknown, then the function throws an exception coded as **CFileException::generic**.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 An operating-system-specific error code.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to the string containing the name of the file that caused the exception, if available.  
  
### Example  
 [!code[NVC_MFCFiles#29](../vs140/codesnippet/CPP/cfileexception-class_6.cpp)]  
  
## See Also  
 [Base Class](../vs140/cexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Exception Processing](../vs140/exception-processing.md)