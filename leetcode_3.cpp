// leetcode_3.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//
/*
未完成！！！
*/
#include "pch.h"
#include <iostream>
#include <unordered_map>
#include <map>
#define _SILENCE_STDEXT_HASH_DEPRECATION_WARNINGS 
using namespace std;

int lengthOfLongestSubstring(string s) {
	int max_count = 0;

	for (int i = 0;s[i] != 0; i++) {	//这个循环遍历每一个字符，确认以这个字符打头的字符串最长是多少
		//map<char, int>* hm = new map<char, int>();//整型记录出现次数
		int isShow[128] = { 0 };
		int count = 0;//计数器
		for (int j = i;; j++) {			//这个循环是从这个字符往后找字符串的过程，直到到末尾或者有重复字符为止
			if (s[j] == 0) {
				break;
			}
			else if (isShow[s[j]] == 0) {	//字符还没重复
				isShow[s[j]] = 1;
				count++;
			}
			else {	//字符重复了
				break;
			}
		}
		if (count > max_count)//打破纪录了，则更新记录
			max_count = count;

	}

	return max_count;
}



int main()
{
	cout << lengthOfLongestSubstring("abcabcbb") << endl;
	cout << lengthOfLongestSubstring("bbbbb") << endl;
	cout << lengthOfLongestSubstring("bbbbb") << endl;
}
