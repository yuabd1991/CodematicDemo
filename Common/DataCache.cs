�}j� 
 %
  ���"2�4�]	0��K3�h���'ޮ~�n�2�eۄ�u'���:U����vǧ�^�Rrhd�d!�0�>'AC2�?�ڕ.��&�A�6eou�`�������u؊:ERm�}T�������d�G����8�CӇ|||R�/sI���w]�d׽U]����x��;%��P`�������ԶZ��7Im��O;Ñ�V�PW��N$ݳ�mx�A9[3������(�`��Kr����䛁���`�}c���0�}X=���%A�~Ta��d��k�L�|�}Rw��I��������QXy	h�?�s��Hi�"'�� ��[�0^uʁ�d�P�h��/��}J��㽲��_Ѡ~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂l�,na]��g����s�O0�vZ֏���.y,�i��䚸MC���B~���8����02�/� "���8ز.$<��B-NAE����ǡ���ܼ�S`���{��s$�2�Ei�Mhb�^�1�~�e%�v�0I�u��l����2�:�6J�� �&�Zn����x	WL��0ʹ[�]T�>>��pM]Yri1Z�袦�Ln����ۦ9�y�`8�'`;�74/@�iE*6IC���o���K� ���g�/Ry�����"!���z��?��G��.b>�XЅ!<?t>$lgA���lG�߁�Y,�F��xA�->|n�1z
?ƻ[א�yI��S�������A���/�T+*.�v*m�Rį�h�a@��v4 6�hI}��rY���ľ��7$�4����[�������NӯR��
�Fgo�>��=)�^�H�Qy��blj
��naMvFJ�L\Mb���S��T��R<\�W_Sf�-M���?c���CH�HN>
		public static void SetCache(string CacheKey, object objObject, DateTime absoluteExpiration,TimeSpan slidingExpiration )
		{
			System.Web.Caching.Cache objCache = HttpRuntime.Cache;
			objCache.Insert(CacheKey, objObject,null,absoluteExpiration,slidingExpiration);
		}
	}
}
