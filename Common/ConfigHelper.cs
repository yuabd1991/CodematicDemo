�}�� 
 $
  x4=~�쵍]	0��J3�h"��'����M��G<�%�u�zJUc:�|�[�>������O� 4X�Jy�Ĵ
��z�Z��9�s�Cj�-_�z�%M~��(���+x����+sE����G�s���	L�#�i��-U����F.H�i/�S�A���!�u$R��q���x�OW�-f���I�6���ʋ���~�Y%-�D��M$�AˬA�:FE��_�L��&<@mWx�-ݽ;7f"(lJ�2����>T]��̌V��h��*��`sH��Čl�Q�����dA��]��e��v\��v��ٿ����E�s�v���*zS�8��5oy�13�8i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂lD��=9�'a��>��}f@\�6�t�6cOǰ�qu��M���{�T\�{��!�;��4��|5�w��R��C��a���Ds�� �N_,̲{�83�m0n0���u{���鏵�^[㚓YE5�w5>��>e͘� �l�����D��;?�I���}�uc�}���� ?a�l�Wɝ�i�Γ�M��hWco��\%F �*(�mCM(�� ��T�y��>iٰ%1<(�Đ��D���roT=nR_8�(�>����Y
��֡�m���6�EEA���\z6 �\Y�~���Ӎ�����Z@��[��cw%�m�Y4�;.ђ�uY���
�F� ��)�b���������-��M%��kMZ�'��Jym�}��c�"�뷄��g�W|۲���D񐿧�U�$�٣��W{#l9�V&�ȶ�1��36�#�@_iy刷2p\��-D�lji&��6�V����ֈ��A�}��.�
c�9��W}`0r{ŜG� ��v���b�/mSM>l�0�[{�.do��2��`�<L�[�L���#@p�>@�|�����8�N����� ��6�����nQ������~A���Pf�|���߰��{@����b�Q�#�[����<��m*ذU��2�r��?��3y@�-&=����c��^�G"Ծ��7�ևM�sv��癦9Ȁv�=�iv¢�����[�Q<��x#N~�C
�B�Q���y����Q'�6��T����QV+4�fX�K|�YH��~ᖛ#�4Mk�0�};֝��,GNU�ѧ���Kq�N[������l�0���&"���"�P���B��;gxy�ӑM%?kﯶ��q�<�{@z0�nL�(zÉ�� �ҍzYg��C� Y'x���:(�,�&=.`�dvH�����tl��>\�k	st�6m�C��47ݔJU�E��>����,���}���v���*�em<=����P�N�³|Yt�T�@�I����b\E̙�:\�#d)�D4wl/������uT�pm�\�K��]q�p�ą��VjI��i���"ߡ��m@;�j=@�u�������-����p����+Jl��|��=�[v?�C`J,�ɐ�
n��^��˝W�F��:��1�!��^�j��D],@�=*olV���^d����΅D+�Ϻd|�%�6ƀ�H9g~gܔ������t���z�y ��H�W.��;�ȹ���H�U�6T�hD�;��Q��1_]*p,AQ�\ȟ�m,�oI67к@�	jh�:	Z� ���2��ɻn ��))�K�S�.�C1do�� q�ݳ��v����abo{��H�Ͼ.�J��dW?]K�5��s3�Oy=p���i�43	:�V�^t4~J  :��ː�S�f�D$n��l��^��@L�W���.���TUv���Ƿ2@wA�L"�3e6/��P,>�Ӧ���CWc���f�+4Ȉ3S�����,LN9���s������-�$Qi�<`�?�@�g��N������9%x���I��AppSettings中的配置int信息
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static int GetConfigInt(string key)
		{
			int result = 0;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = int.Parse(cfgVal);
				}
				catch(FormatException)
				{
					// Ignore format exceptions.
				}
			}

			return result;
		}
	}
}
