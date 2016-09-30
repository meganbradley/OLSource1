---
title: "CPathT Class"
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
  - "ATL.CPathT"
  - "CPathT"
  - "ATL::CPathT<StringType>"
  - "ATL::CPathT"
  - "ATL.CPathT<StringType>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPathT class"
ms.assetid: eba4137d-1fd2-4b44-a2e1-0944db64df3c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPathT Class
This class represents a path.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The ATL/MFC string class to use for the path (see                         [CStringT](../vs140/cstringt-class.md)).  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CPathT::PCXSTR](../vs140/cpatht--pcxstr.md)|A constant string type.|  
|[CPathT::PXSTR](../vs140/cpatht--pxstr.md)|A string type.|  
|[CPathT::XCHAR](../vs140/cpatht--xchar.md)|A character type.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPathT::CPathT](../vs140/cpatht--cpatht.md)|The constructor for the path.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPathT::AddBackslash](../vs140/cpatht--addbackslash.md)|Call this method to add a backslash to the end of a string to create the correct syntax for a path.|  
|[CPathT::AddExtension](../vs140/cpatht--addextension.md)|Call this method to add a file extension to a path.|  
|[CPathT::Append](../vs140/cpatht--append.md)|Call this method to append a string to the current path.|  
|[CPathT::BuildRoot](../vs140/cpatht--buildroot.md)|Call this method to create a root path from a given drive number.|  
|[CPathT::Canonicalize](../vs140/cpatht--canonicalize.md)|Call this method to convert the path to canonical form.|  
|[CPathT::Combine](../vs140/cpatht--combine.md)|Call this method to concatenate a string representing a directory name and a string representing a file path name into one path.|  
|[CPathT::CommonPrefix](../vs140/cpatht--commonprefix.md)|Call this method to determine whether the specified path shares a common prefix with the current path.|  
|[CPathT::CompactPath](../vs140/cpatht--compactpath.md)|Call this method to truncate a file path to fit within a given pixel width by replacing path components with ellipses.|  
|[CPathT::CompactPathEx](../vs140/cpatht--compactpathex.md)|Call this method to truncate a file path to fit within a given number of characters by replacing path components with ellipses.|  
|[CPathT::FileExists](../vs140/cpatht--fileexists.md)|Call this method to check whether the file at this path name exists.|  
|[CPathT::FindExtension](../vs140/cpatht--findextension.md)|Call this method to find the position of the file extension within the path.|  
|[CPathT::FindFileName](../vs140/cpatht--findfilename.md)|Call this method to find the position of the file name within the path.|  
|[CPathT::GetDriveNumber](../vs140/cpatht--getdrivenumber.md)|Call this method to search the path for a drive letter within the range of 'A' to 'Z' and return the corresponding drive number.|  
|[CPathT::GetExtension](../vs140/cpatht--getextension.md)|Call this method to get the file extension from the path.|  
|[CPathT::IsDirectory](../vs140/cpatht--isdirectory.md)|Call this method to check whether the path is a valid directory.|  
|[CPathT::IsFileSpec](../vs140/cpatht--isfilespec.md)|Call this method to search a path for any path-delimiting characters (for example, ':' or '\\' ). If there are no path-delimiting characters present, the path is considered to be a File Spec path.|  
|[CPathT::IsPrefix](../vs140/cpatht--isprefix.md)|Call this method to determine whether a path contains a valid prefix of the type passed by                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
|[CPathT::IsRelative](../vs140/cpatht--isrelative.md)|Call this method to determine if the path is relative.|  
|[CPathT::IsRoot](../vs140/cpatht--isroot.md)|Call this method to determine if the path is a directory root.|  
|[CPathT::IsSameRoot](../vs140/cpatht--issameroot.md)|Call this method to determine whether another path has a common root component with the current path.|  
|[CPathT::IsUNC](../vs140/cpatht--isunc.md)|Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server and share.|  
|[CPathT::IsUNCServer](../vs140/cpatht--isuncserver.md)|Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server only.|  
|[CPathT::IsUNCServerShare](../vs140/cpatht--isuncservershare.md)|Call this method to determine whether the path is a valid UNC (universal naming convention) share path, \\\                                        *server*\                                        *share*.|  
|[CPathT::MakePretty](../vs140/cpatht--makepretty.md)|Call this method to convert a path to all lowercase characters to give the path a consistent appearance.|  
|[CPathT::MatchSpec](../vs140/cpatht--matchspec.md)|Call this method to search the path for a string containing a wildcard match type.|  
|[CPathT::QuoteSpaces](../vs140/cpatht--quotespaces.md)|Call this method to enclose the path in quotation marks if it contains any spaces.|  
|[CPathT::RelativePathTo](../vs140/cpatht--relativepathto.md)|Call this method to create a relative path from one file or folder to another.|  
|[CPathT::RemoveArgs](../vs140/cpatht--removeargs.md)|Call this method to remove any command-line arguments from the path.|  
|[CPathT::RemoveBackslash](../vs140/cpatht--removebackslash.md)|Call this method to remove the trailing backslash from the path.|  
|[CPathT::RemoveBlanks](../vs140/cpatht--removeblanks.md)|Call this method to remove all leading and trailing spaces from the path.|  
|[CPathT::RemoveExtension](../vs140/cpatht--removeextension.md)|Call this method to remove the file extension from the path, if there is one.|  
|[CPathT::RemoveFileSpec](../vs140/cpatht--removefilespec.md)|Call this method to remove the trailing file name and backslash from the path, if it has them.|  
|[CPathT::RenameExtension](../vs140/cpatht--renameextension.md)|Call this method to replace the file name extension in the path with a new extension. If the file name does not contain an extension, the extension will be attached to the end of the string.|  
|[CPathT::SkipRoot](../vs140/cpatht--skiproot.md)|Call this method to parse a path, ignoring the drive letter or UNC server/share path parts.|  
|[CPathT::StripPath](../vs140/cpatht--strippath.md)|Call this method to remove the path portion of a fully qualified path and file name.|  
|[CPathT::StripToRoot](../vs140/cpatht--striptoroot.md)|Call this method to remove all parts of the path except for the root information.|  
|[CPathT::UnquoteSpaces](../vs140/cpatht--unquotespaces.md)|Call this method to remove quotation marks from the beginning and end of a path.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CPathT::operator const StringType &](../vs140/cpatht--operator-const-stringtype--.md)|This operator allows the object to be treated like a string.|  
|[CPathT::operator PCXSTR](../vs140/cpatht--operator-cpatht--pcxstr.md)|This operator allows the object to be treated like a string.|  
|[CPathT::operator StringType &](../vs140/cpatht--operator-stringtype--.md)|This operator allows the object to be treated like a string.|  
|[CPathT::operator +=](../vs140/cpatht--operator--=.md)|This operator appends a string to the path.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPathT::m_strPath](../vs140/cpatht--m_strpath.md)|The path.|  
  
## Remarks  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> are instantiations of                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> defined as follows:  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlpath.h  
  
##  \<a name="cpatht__addbackslash">\</a>  CPathT::AddBackslash  
 Call this method to add a backslash to the end of a string to create the correct syntax for a path. If the path already has a trailing backslash, no backslash will be added.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathAddBackSlash](http://msdn.microsoft.com/library/windows/desktop/bb773561).  
  
##  \<a name="cpatht__addextension">\</a>  CPathT::AddExtension  
 Call this method to add a file extension to a path.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The file extension to add.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathAddExtension](http://msdn.microsoft.com/library/windows/desktop/bb773563).  
  
##  \<a name="cpatht__append">\</a>  CPathT::Append  
 Call this method to append a string to the current path.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The string to append.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathAppend](http://msdn.microsoft.com/library/windows/desktop/bb773565).  
  
##  \<a name="cpatht__buildroot">\</a>  CPathT::BuildRoot  
 Call this method to create a root path from a given drive number.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *iDrive*  
 The drive number (0 is A:, 1 is B:, and so on).  
  
### Remarks  
 For more information, see                         [PathBuildRoot](http://msdn.microsoft.com/library/windows/desktop/bb773567).  
  
##  \<a name="cpatht__canonicalize">\</a>  CPathT::Canonicalize  
 Call this method to convert the path to canonical form.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathCanonicalize](http://msdn.microsoft.com/library/windows/desktop/bb773569).  
  
##  \<a name="cpatht__combine">\</a>  CPathT::Combine  
 Call this method to concatenate a string representing a directory name and a string representing a file path name into one path.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The directory path.  
  
 *pszFile*  
 The file path.  
  
### Remarks  
 For more information, see                         [PathCombine](http://msdn.microsoft.com/library/windows/desktop/bb773571).  
  
##  \<a name="cpatht__commonprefix">\</a>  CPathT::CommonPrefix  
 Call this method to determine whether the specified path shares a common prefix with the current path.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The path to compare to the current one.  
  
### Return Value  
 Returns the common prefix.  
  
### Remarks  
 A prefix is one of these types: "C:\\\\", ".", "..", "..\\\\". For more information, see                         [PathCommonPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773574).  
  
##  \<a name="cpatht__compactpath">\</a>  CPathT::CompactPath  
 Call this method to truncate a file path to fit within a given pixel width by replacing path components with ellipses.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The device context used for font metrics.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The width, in pixels, that the string will be forced to fit in.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathCompactPath](http://msdn.microsoft.com/library/windows/desktop/bb773575).  
  
##  \<a name="cpatht__compactpathex">\</a>  CPathT::CompactPathEx  
 Call this method to truncate a file path to fit within a given number of characters by replacing path components with ellipses.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The maximum number of characters to be contained in the new string, including the terminating NULL character.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Reserved.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathCompactPathEx](http://msdn.microsoft.com/library/windows/desktop/bb773578).  
  
##  \<a name="cpatht__cpatht">\</a>  CPathT::CPathT  
 The constructor.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *pszPath*  
 The pointer to a path string.  
  
 *path*  
 The path string.  
  
##  \<a name="cpatht__fileexists">\</a>  CPathT::FileExists  
 Call this method to check whether the file at this path name exists.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the file exists, FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathFileExists](http://msdn.microsoft.com/library/windows/desktop/bb773584).  
  
##  \<a name="cpatht__findextension">\</a>  CPathT::FindExtension  
 Call this method to find the position of the file extension within the path.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns the position of the "." preceding the extension. If no extension is found, returns –1.  
  
### Remarks  
 For more information, see                         [PathFindExtension](http://msdn.microsoft.com/library/windows/desktop/bb773587).  
  
##  \<a name="cpatht__findfilename">\</a>  CPathT::FindFileName  
 Call this method to find the position of the file name within the path.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Returns the position of the file name. If no file name is found, returns –1.  
  
### Remarks  
 For more information, see                         [PathFindFileName](http://msdn.microsoft.com/library/windows/desktop/bb773589).  
  
##  \<a name="cpatht__getdrivenumber">\</a>  CPathT::GetDriveNumber  
 Call this method to search the path for a drive letter within the range of 'A' to 'Z' and return the corresponding drive number.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Returns the drive number as an integer from 0 through 25 (corresponding to 'A' through 'Z') if the path has a drive letter, or -1 otherwise.  
  
### Remarks  
 For more information, see                         [PathGetDriveNumber](http://msdn.microsoft.com/library/windows/desktop/bb773612).  
  
##  \<a name="cpatht__getextension">\</a>  CPathT::GetExtension  
 Call this method to get the file extension from the path.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns the file extension.  
  
##  \<a name="cpatht__isdirectory">\</a>  CPathT::IsDirectory  
 Call this method to check whether the path is a valid directory.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Returns a non-zero value (16) if the path is a directory,                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 For more information, see                         [PathIsDirectory](http://msdn.microsoft.com/library/windows/desktop/bb773621).  
  
##  \<a name="cpatht__isfilespec">\</a>  CPathT::IsFileSpec  
 Call this method to search a path for any path-delimiting characters (for example, ':' or '\\' ). If there are no path-delimiting characters present, the path is considered to be a File Spec path.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if there are no path-delimiting characters within the path, or FALSE if there are path-delimiting characters.  
  
### Remarks  
 For more information, see                         [PathIsFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773627).  
  
##  \<a name="cpatht__isprefix">\</a>  CPathT::IsPrefix  
 Call this method to determine whether a path contains a valid prefix of the type passed by                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The prefix for which to search. A prefix is one of these types: "C:\\\\", ".", "..", "..\\\\".  
  
### Return Value  
 Returns TRUE if the path contains the prefix, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsPrefix](http://msdn.microsoft.com/library/windows/desktop/bb773650).  
  
##  \<a name="cpatht__isrelative">\</a>  CPathT::IsRelative  
 Call this method to determine if the path is relative.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the path is relative, or FALSE if it is absolute.  
  
### Remarks  
 For more information, see                         [PathIsRelative](http://msdn.microsoft.com/library/windows/desktop/bb773660).  
  
##  \<a name="cpatht__isroot">\</a>  CPathT::IsRoot  
 Call this method to determine if the path is a directory root.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the path is a root, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsRoot](http://msdn.microsoft.com/library/windows/desktop/bb773674).  
  
##  \<a name="cpatht__issameroot">\</a>  CPathT::IsSameRoot  
 Call this method to determine whether another path has a common root component with the current path.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The other path.  
  
### Return Value  
 Returns TRUE if both strings have the same root component, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsSameRoot](http://msdn.microsoft.com/library/windows/desktop/bb773687).  
  
##  \<a name="cpatht__isunc">\</a>  CPathT::IsUNC  
 Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server and share.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the path is a valid UNC path, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsUNC](http://msdn.microsoft.com/library/windows/desktop/bb773712).  
  
##  \<a name="cpatht__isuncserver">\</a>  CPathT::IsUNCServer  
 Call this method to determine whether the path is a valid UNC (universal naming convention) path for a server only.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the string is a valid UNC path for a server only (no share name), or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsUNCServer](http://msdn.microsoft.com/library/windows/desktop/bb773722).  
  
##  \<a name="cpatht__isuncservershare">\</a>  CPathT::IsUNCServerShare  
 Call this method to determine whether the path is a valid UNC (universal naming convention) share path, \\\                *server*\                *share*.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the path is in the form \\\                        *server*\                        *share*, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathIsUNCServerShare](http://msdn.microsoft.com/library/windows/desktop/bb773723).  
  
##  \<a name="cpatht__m_strpath">\</a>  CPathT::m_strPath  
 The path.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is the template parameter to                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
##  \<a name="cpatht__makepretty">\</a>  CPathT::MakePretty  
 Call this method to convert a path to all lowercase characters to give the path a consistent appearance.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if the path has been converted, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathMakePretty](http://msdn.microsoft.com/library/windows/desktop/bb773725).  
  
##  \<a name="cpatht__matchspec">\</a>  CPathT::MatchSpec  
 Call this method to search the path for a string containing a wildcard match type.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string with the file type for which to search. For example, to test whether the file at the current path is a DOC file,                                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> should be set to "*.doc".  
  
### Return Value  
 Returns TRUE if the string matches, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathMatchSpec](http://msdn.microsoft.com/library/windows/desktop/bb773727).  
  
##  \<a name="cpatht__operator__add_eq">\</a>  CPathT::operator +=  
 This operator appends a string to the path.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The string to append.  
  
### Return Value  
 Returns the updated path.  
  
##  \<a name="cpatht__operator_const_stringtype__amp_">\</a>  CPathT::operator const StringType &amp;  
 This operator allows the object to be treated like a string.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Returns a string representing the current path managed by this object.  
  
##  \<a name="cpatht__operator_cpatht__pcxstr">\</a>  CPathT::operator CPathT::PCXSTR  
 This operator allows the object to be treated like a string.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Returns a string representing the current path managed by this object.  
  
##  \<a name="cpatht__operator_stringtype__amp_">\</a>  CPathT::operator StringType &amp;  
 This operator allows the object to be treated like a string.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 Returns a string representing the current path managed by this object.  
  
##  \<a name="cpatht__pcxstr">\</a>  CPathT::PCXSTR  
 A constant string type.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is the template parameter to                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
##  \<a name="cpatht__pxstr">\</a>  CPathT::PXSTR  
 A string type.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is the template parameter to                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
##  \<a name="cpatht__quotespaces">\</a>  CPathT::QuoteSpaces  
 Call this method to enclose the path in quotation marks if it contains any spaces.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathQuoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773739).  
  
##  \<a name="cpatht__relativepathto">\</a>  CPathT::RelativePathTo  
 Call this method to create a relative path from one file or folder to another.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The start of the relative path.  
  
 *dwAttrFrom*  
 The File attributes of                                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. If this value contains FILE_ATTRIBUTE_DIRECTORY,                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is assumed to be a directory; otherwise,                                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is assumed to be a file.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The end point of the relative path.  
  
 *dwAttrTo*  
 The File attributes of                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. If this value contains FILE_ATTRIBUTE_DIRECTORY,                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is assumed to be a directory; otherwise,                                 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is assumed to be a file.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathRelativePathTo](http://msdn.microsoft.com/library/windows/desktop/bb773740).  
  
##  \<a name="cpatht__removeargs">\</a>  CPathT::RemoveArgs  
 Call this method to remove any command-line arguments from the path.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathRemoveArgs](http://msdn.microsoft.com/library/windows/desktop/bb773742).  
  
##  \<a name="cpatht__removebackslash">\</a>  CPathT::RemoveBackslash  
 Call this method to remove the trailing backslash from the path.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathRemoveBackslash](http://msdn.microsoft.com/library/windows/desktop/bb773743).  
  
##  \<a name="cpatht__removeblanks">\</a>  CPathT::RemoveBlanks  
 Call this method to remove all leading and trailing spaces from the path.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathRemoveBlanks](http://msdn.microsoft.com/library/windows/desktop/bb773745).  
  
##  \<a name="cpatht__removeextension">\</a>  CPathT::RemoveExtension  
 Call this method to remove the file extension from the path, if there is one.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathRemoveExtension](http://msdn.microsoft.com/library/windows/desktop/bb773746).  
  
##  \<a name="cpatht__removefilespec">\</a>  CPathT::RemoveFileSpec  
 Call this method to remove the trailing file name and backslash from the path, if it has them.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathRemoveFileSpec](http://msdn.microsoft.com/library/windows/desktop/bb773748).  
  
##  \<a name="cpatht__renameextension">\</a>  CPathT::RenameExtension  
 Call this method to replace the file name extension in the path with a new extension. If the file name does not contain an extension, the extension will be attached to the end of the path.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The new file name extension, preceded by a "." character.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 For more information, see                         [PathRenameExtension](http://msdn.microsoft.com/library/windows/desktop/bb773749).  
  
##  \<a name="cpatht__skiproot">\</a>  CPathT::SkipRoot  
 Call this method to parse a path, ignoring the drive letter or UNC (universal naming convention) server/share path parts.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Returns the position of the beginning of the subpath that follows the root (drive letter or UNC server/share).  
  
### Remarks  
 For more information, see                         [PathSkipRoot](http://msdn.microsoft.com/library/windows/desktop/bb773754).  
  
##  \<a name="cpatht__strippath">\</a>  CPathT::StripPath  
 Call this method to remove the path portion of a fully qualified path and file name.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathStripPath](http://msdn.microsoft.com/library/windows/desktop/bb773756).  
  
##  \<a name="cpatht__striptoroot">\</a>  CPathT::StripToRoot  
 Call this method to remove all parts of the path except for the root information.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if a valid drive letter was found in the path, or FALSE otherwise.  
  
### Remarks  
 For more information, see                         [PathStripToRoot](http://msdn.microsoft.com/library/windows/desktop/bb773757).  
  
##  \<a name="cpatht__unquotespaces">\</a>  CPathT::UnquoteSpaces  
 Call this method to remove quotation marks from the beginning and end of a path.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [PathUnquoteSpaces](http://msdn.microsoft.com/library/windows/desktop/bb773763).  
  
##  \<a name="cpatht__xchar">\</a>  CPathT::XCHAR  
 A character type.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is the template parameter to                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.  
  
## See Also  
 [ATL Classes](../vs140/atl-classes.md)   
 [CStringT Class](../vs140/cstringt-class.md)