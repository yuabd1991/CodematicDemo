�}�� 
 3
  ���4�i�]	0��F3�v�>�����J��F��[)t5���+п	��},A0�#oJ��H�0�g��/�1trG���������;�U�(�9�E��\������l�ñc����}Y�.����y ����!:@-����-(/�fO�^By�uB�z/[%��V<O��S�B?s��	Em�1g��>|��V�cKF��ϼ�=Ǧ#"��؃�����UGŨɕ�1$�ʸ�F\|U���2Sj�,�����F�k\N V���M=�p����[�nz���^�?��Ǫ(�rB���x��y���/�*�
�C&A:r��M��� ����$�B��>�q
`i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂l�-	>����<�6ߛ{���Fc�٢ww�]:��{_O9=�f]����r>F��`�',�v�M�{:�f��q�Ơn�%\u+d��'^��z�h+�2���Gξ�A%S��K=���v����l�ʯe�K/�w�i����:h)~JK���<`6^����*���b���s�E�f)�d�Z"��rB��L��u<+�D�L}6��*�T?n��9����dF��L�끧**>�c��=�(�'E�;?vQ�&�5����Zk)?���n�r���*����ԧ�U"p�lڷ<�ؕ k�H�J#��R�o�pՉU��^��Z~�B�����A�a���]��5�qS��O�h����y_�}=G���#���H*�.�gZ�37 ӈ��w��D!�ܧ)o<0�.���M�T�Պ�1n��Y6�[^�O�d�(''��嵄m"���dY����+��faL�҇�#<�5��lG1��OLM����B���Gȼ�u�~?Xg�byte[] Value;
			UnicodeEncoding Code = new UnicodeEncoding();
			byte[] Message = Code.GetBytes(Security);
			SHA512Managed Arithmetic = new SHA512Managed();
			Value = Arithmetic.ComputeHash(Message);
			Security = "";
			foreach(byte o in Value)
			{
				Security += (int) o + "O";
			}
			return Security;
		}
	}
}
