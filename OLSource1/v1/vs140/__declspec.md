---
title: "__declspec"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__declspec_cpp"
  - "__declspec"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++]"
ms.assetid: 832db681-e8e1-41ca-b78c-cd9d265cdb87
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __declspec
## Microsoft Specific  
 The extended attribute syntax for specifying storage-class information uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword, which specifies that an instance of a given type is to be stored with a Microsoft-specific storage-class attribute listed below. Examples of other storage-class modifiers include the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keywords. However, these keywords are part of the ANSI specification of the C and C++ languages, and as such are not covered by extended attribute syntax. The extended attribute syntax simplifies and standardizes Microsoft-specific extensions to the C and C++ languages.  
  
## Grammar  
 *decl-specifier*:  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  *extended-decl-modifier-seq*  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 *extended-decl-modifier-seq*:  
 *extended-decl-modifier*opt  
  
 *extended-decl-modifier extended-decl-modifier-seq*  
  
 *extended-decl-modifier*:  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> *#* <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> *segname* <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> *segname* <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>{<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>*get_func_name*&#124;<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>*put_func_name*}<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> *ComObjectGUID* <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 White space separates the declaration modifier sequence. Examples appear in later sections.  
  
 Extended attribute grammar supports these Microsoft-specific storage-class attributes: [align](../vs140/align--c---.md), [allocate](../vs140/allocate.md), [appdomain](../vs140/appdomain.md), [code_seg](../vs140/code_seg--__declspec-.md), [deprecated](../vs140/deprecated--c---.md), [dllexport](../vs140/dllexport--dllimport.md), [dllimport](../vs140/dllexport--dllimport.md), [jitintrinsic](../vs140/jitintrinsic.md), [naked](../vs140/naked--c---.md), [noalias](../vs140/noalias.md), [noinline](../vs140/noinline.md), [noreturn](../vs140/noreturn.md), [nothrow](../vs140/nothrow--c---.md), [novtable](../vs140/novtable.md), [process](../vs140/process.md), [restrict](../vs140/restrict.md), [safebuffers](../vs140/safebuffers.md), [selectany](../vs140/selectany.md), and [thread](../vs140/thread.md). It also supports these COM-object attributes: [property](../vs140/property--c---.md) and [uuid](../vs140/uuid--c---.md).  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> storage-class attributes are properties only of the declaration of the object or function to which they are applied. The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute affects data and objects only. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> attribute affects functions only. The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> attributes affect functions, data, and objects. The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> attributes affect COM objects.  
  
 The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> keywords should be placed at the beginning of a simple declaration. The compiler ignores, without warning, any <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> keywords placed after * or & and in front of the variable identifier in a declaration.  
  
 A <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> attribute specified in the beginning of a user-defined type declaration applies to the variable of that type. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this case, the attribute applies to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> attribute placed after the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> keyword applies to the user-defined type. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this case, the attribute applies to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 The general guideline for using the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> attribute for simple declarations is as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The *decl-specifier-seq* should contain, among other things, a base type (e.g. <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, or a class name), a storage class (e.g. <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>), or the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> extension. The *init-declarator-list* should contain, among other things, the pointer part of declarations. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The following code declares an integer thread local variable and initializes it with a value:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [C Extended Storage-Class Attributes](../vs140/c-extended-storage-class-attributes.md)