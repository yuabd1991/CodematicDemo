�}�� 
 8
  �G�ة��]	0��23�v�>�����J��F��[)t5����{��-W�ϩ���22ө�%ngN��b��v�:*
�6��1�t����ȑ��T�O�ǣ!T��@�k��o]H��MHG��oO&Ez射}[�;���hlv�^����n줏S�9���!�0L���(���
�g��.r�ؒ|����G1�Fqf>U�m-5ՑN_p8�UGQ���Sv�脝*�g�w'�	H6���qݞ[��S�����M�.�� �f�&�GU?����Q�a��$���'@����)6�E�@ S�I ������/���$��0�ӀC�군��y��q
`i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂�CacheKey的Cache值
		/// </summary>
		/// <param name="CacheKey"></param>
		/// <param name="objObject"></param>
		public static void SetCache(string CacheKey, object objObject)
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject);
		}
	}
}
