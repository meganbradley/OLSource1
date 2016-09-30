---
title: "path Class (C++ Standard Template Library)"
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
  - "filesystem/std::tr2::sys::path"
dev_langs: 
  - "C++"
ms.assetid: 8a1227ca-aeb2-4e0e-84aa-86e34e4f4fe8
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# path Class (C++ Standard Template Library)
The **path** class stores an object of type string_type, called myname here for the purposes of exposition, suitable for use as a pathname. string_type is a synonym for basic_string\<value_type>, where value_type is a synonym for char under Windows or wchar_t under Posix.  
  
 For more information, and code examples, see [File System Navigation](../vs140/file-system-navigation.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## path::append  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The member functions append the specified sequence to mypath, converted and inserting a preferred_separator as needed.  
  
## path::assign  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The member functions replace mypath with the specified sequence, converted as needed.  
  
## path::begin  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Returns a path::iterator designating the first path element in the pathname, if present.  
  
## path::c_str  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Returns a pointer to the first character in mypath.  
  
## path::clear  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The member function executes mypath.clear()  
  
## path::compare  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The first function returns mypath.compare(pval.native()). The second function returns mypath.compare(str). The third function returns mypath.compare(ptr).  
  
## path::concat  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The member functions append the specified sequence to mypath, converted (but not inserting a separator) as needed.  
  
## path::const_iterator  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type is a synonym for iterator.  
  
## path::empty  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Returns mypath.empty().  
  
## path::end  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Returns an end-of-sequence iterator of type iterator.  
  
## path::extension  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Returns the suffix of filename() X such that:  
  
 If X == path(".") &#124;&#124; X == path("..") or if X contains no dot, the suffix is empty.  
  
 Otherwise, the suffix begins with (and includes) the rightmost dot.  
  
## path::filename  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Returns the root directory component of myname, specifically <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. The component may be empty.  
  
## path::generic_string  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Returns <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> with (under Windows) any backslash converted to a forward slash.  
  
## path::generic_u16string  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Returns u16string() with (under Windows) any backslash converted to a forward slash.  
  
## path::generic_u32string  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Returns u32string() with (under Windows) any backslash converted to a forward slash.  
  
## path::generic_u8string  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Returns u8string() with (under Windows) any backslash converted to a forward slash.  
  
## path::generic_wstring  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Returns wstring() with (under Windows) any backslash converted to a forward slash.  
  
## path::has_extension  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Returns !extension().empty().  
  
## path::has_filename  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Returns !filename().empty().  
  
## path::has_parent_path  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Returns !parent_path().empty().  
  
## path::has_relative_path  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Returns !relative_path().empty().  
  
## path::has_root_directory  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Returns !root_directory().empty().  
  
## path::has_root_name  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Returns !root_name().empty().  
  
## path::has_root_path  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Returns !root_path().empty().  
  
## path::has_stem  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Returns !stem().empty().  
  
## path::is_absolute  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 For Windows, the function returns has_root_name() && has_root_directory(). For Posix, the function returns has_root_directory().  
  
## path::is_relative  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Returns !is_absolute().  
  
## path::iterator  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The class describes a bidirectional constant iterator that designates the path components of myname in the sequence:  
  
1.  the root name, if present  
  
2.  the root directory, if present  
  
3.  the remaining directory elements of the parent path, if present, ending withthe filename, if present  
  
4.  
  
5.  
  
 For pval an object of type path:  
  
1.  path::iterator X = pval.begin() designates the first path element in the pathname, if present.  
  
2.  X == pval.end() is true when X points just past the end of the sequence of components.  
  
3.  *X returns a string that matches the current component  
  
4.  ++X designates the next component in the sequence, if present.  
  
5.  --X designates the preceding component in the sequence, if present.  
  
6.  Altering myname invalidates all iterators designating elements in myname.  
  
## path::make_preferred  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The member function converts each separator to a preferred_separator as needed.  
  
## path::native  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Returns myname.  
  
## path::operator=  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The first member operator copies right.myname to myname. The second member operator moves right.myname to myname. The third member operator behaves the same as *this = path(source).  
  
## path::operator+=  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The member functions behave the same as the following corresponding expressions:  
  
1.  concat(right);  
  
2.  concat(path(str));  
  
3.  concat(ptr);  
  
4.  concat(string_type(1, elem));  
  
5.  concat(source);  
  
6.  concat(path(basic_string\<Elem>(1, elem)));  
  
## path::operator/=  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The member functions behave the same as the following corresponding expressions:  
  
1.  append(right);  
  
2.  append(source);  
  
## path::operator string_type  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The member operator returns myname.  
  
## path::parent_path  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Returns the parent path component of myname, specifically the prefix of myname after removing filename().native() and any immediately preceding directory separators. (Equally, if begin() != end(), it is the combining of all elements in the range [begin(), --end()) by successively applying operator/=.) The component may be empty.  
  
## path::path  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The constructors all construct myname in various ways:  
  
 For path() it is myname().  
  
 For path(const path& right) it is myname(right.myname).  
  
 For path(path&& right) it is myname(right.myname).  
  
 For template\<class Source> path(const Source& source) it is myname(source).  
  
 For template\<class Source> path(const Source& source, const locale& loc) it is myname(source), obtaining any needed codecvt facets from loc.  
  
 For template\<class InIt> path(InIt first, InIt last) it is myname(first, last).  
  
 For template\<class InIt> path(InIt first, InIt last, const locale& loc) it is myname(first, last), obtaining any needed codecvt facets from loc.  
  
## path::preferred_separator  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The constant object gives the preferred character for separating path components, depending on the host operating system. Note that it is equally permissible in most contexts under Windows to use L'/' in its place.  
  
## path::relative_path  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Returns the relative path component of myname, specifically the suffix of myname after removing root_path().native() and any immediately subsequent redundant directory separators. The component may be empty.  
  
## path::remove_filename  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
## path::replace_extension  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The member function first removes the suffix extension().native() from myname. Then if !newext.empty() && newext[0] != dot (where dot is *path(".").c_str()), then dot is appended to myname. Then newext is appended to myname.  
  
## path::replace_filename  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The member function executes:  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
## path::root_directory  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Returns the root directory component of myname. The component may be empty.  
  
## path::root_name  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Returns the root name component of myname. The component may be empty.  
  
## path::root_path  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Returns the root path component of myname, specifically root_name() / root_directory. The component may be empty.  
  
## path::stem  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Returns the stem component of myname, specifically filename().native() with any trailing extension().native() removed. The component may be empty.  
  
## path::string  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The first (template) member function converts the sequence stored in mypath the same way as:  
  
1.  string() for string\<char, Traits, Alloc>()  
  
2.  wstring() for string\<wchar_t, Traits, Alloc>()  
  
3.  u16string() for string\<char16_t, Traits, Alloc>()  
  
4.  u32string() for string\<char32_t, Traits, Alloc>()  
  
 The second member function converts the sequence stored in mypath to the encoding favored by the host system for a char sequence and returns it stored in an object of type string.  
  
## path::string_type  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The type is a synonym for basic_string\<value_type>.  
  
## path::swap  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Executes swap(mypath, right.mypath).  
  
## path::u16string  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The member function converts the sequence stored in mypath to UTF-16 and returns it stored in an object of type u16string.  
  
## path::u32string  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The member function converts the sequence stored in mypath to UTF-32 and returns it stored in an object of type u32string.  
  
## path::u8string  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The member function converts the sequence stored in mypath to UTF-8 and returns it stored in an object of type u8string.  
  
## path::value_type  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The type describes the path elements favored by the host operating system.  
  
## path::wstring  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Converts the sequence stored in mypath to the encoding favored by the host system for a wchar_t sequence and returns it stored in an object of type wstring.  
  
## Requirements  
 **Header:** filesystem  
  
 **Namespace:** std::tr2::sys  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)