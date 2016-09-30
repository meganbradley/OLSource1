---
title: "#include Directive (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#include Directive (C/C++)"
f1_keywords: 
  - "#include"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "preprocessor, directives"
  - "#include directive"
  - "include directive (#include)"
ms.assetid: 17067dc0-8db1-4f2d-b43e-ec12ecf83238
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #include Directive (C-C++)
Tells the preprocessor to treat the contents of a specified file as if they appear in the source program at the point where the directive appears.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can organize constant and macro definitions into include files and then use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directives to add them to any source file. Include files are also useful for incorporating declarations of external variables and complex data types. The types may be defined and named only once in an include file created for that purpose.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a file name that may optionally be preceded by a directory specification. The file name must name an existing file. The syntax of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> depends on the operating system on which the program is compiled.  
  
 For information about how to reference assemblies in a C++ application that's compiled by using [/clr](../vs140/-clr--common-language-runtime-compilation-.md), see [#using](../vs140/sharpusing-directive--c---.md).  
  
 Both syntax forms cause that directive to be replaced by the entire contents of the specified include file. The difference between the two forms is the order in which the preprocessor searches for header files when the path is incompletely specified. The following table shows the difference between the two syntax forms.  
  
|Syntax Form|Action|  
|-----------------|------------|  
|Quoted form|The preprocessor searches for include files in this order:\<br />\<br /> 1) In the same directory as the file that contains the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement.\<br />\<br /> 2) In the directories of the currently opened include files, in the reverse order in which they were opened. The search begins in the directory of the parent include file and continues upward through the directories of any grandparent include files.\<br />\<br /> 3) Along the path that's specified by each /I compiler option.\<br />\<br /> 4)\<br />\<br /> Along the paths that are specified by the INCLUDE environment variable.|  
|Angle-bracket form|The preprocessor searches for include files in this order:\<br />\<br /> 1) Along the path that's specified by each /I compiler option.\<br />\<br /> 2) When compiling occurs on the command line, along the paths that are specified by the INCLUDE environment variable.|  
  
 The preprocessor stops searching as soon as it finds a file that has the given name. If you enclose a complete, unambiguous path specification for the include file between double quotation marks (" "), the preprocessor searches only that path specification and ignores the standard directories.  
  
 If the file name that's enclosed in double quotation marks is an incomplete path specification, the preprocessor first searches the "parent" file's directory. A parent file is the file that contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive. For example, if you include a file named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in a file named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the parent file.  
  
 Include files can be "nested"; that is, an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directive can appear in a file that's named by another <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> directive. For example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> could include <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. In this case, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> would still be the parent of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, but it would be the "grandparent" of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 When include files are nested and when compiling occurs on the command line, directory searching begins with the directories of the parent file and then proceeds through the directories of any grandparent files. That is, searching begins relative to the directory that contains the source that's currently being processed. If the file is not found, the search moves to directories that are specified by the /I compiler option. Finally, the directories that are specified by the INCLUDE environment variable are searched.  
  
 From the development environment, the INCLUDE environment variable is ignored. For information about how to set the directories that are searched for include files—this also applies to the LIB environment variable—see [VC++ Directories Property Page](../vs140/vc---directories-property-page.md).  
  
 This example shows file inclusion by using angle brackets:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example adds the contents of the file named STDIO.H to the source program. The angle brackets cause the preprocessor to search the directories that are specified by the INCLUDE environment variable for STDIO.H, after it searches directories that are specified by the /I compiler option.  
  
 The next example shows file inclusion by using the quoted form:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This example adds the contents of the file that's specified by DEFS.H to the source program. The quotation marks mean that the preprocessor first searches the directory that contains the parent source file.  
  
 Nesting of include files can continue up to 10 levels. When the nested <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is processed, the preprocessor continues to insert the enclosing include file into the original source file.  
  
 **Microsoft Specific**  
  
 To locate includable source files, the preprocessor first searches the directories that are specified by the /I compiler option. If the /I option is not present or fails, the preprocessor uses the INCLUDE environment variable to find any include files within angle brackets. The INCLUDE environment variable and /I compiler option can contain multiple paths, separated by semicolons (;). If more than one directory appears as part of the /I option or within the INCLUDE environment variable, the preprocessor searches them in the order in which they appear.  
  
 For example, the command  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 causes the preprocessor to search the directory D:\MSVC\INCLUDE\ for include files such as STDIO.H. The commands  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 have the same effect. If both sets of searches fail, a fatal compiler error is generated.  
  
 If the file name is fully specified for an include file that has a path that includes a colon (for example, F:\MSVC\SPECIAL\INCL\TEST.H), the preprocessor follows the path.  
  
 For include files that are specified as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> "<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>", directory searching begins with the directory of the parent file and then proceeds through the directories of any grandparent files. That is, searching begins relative to the directory that contains the source file that contains the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> directive that's being processed. If there is no grandparent file and the file has not been found, the search continues as if the file name were enclosed in angle brackets.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)