�}� 
 E
  i�&�>��]	0��� 3�v�>�����J��F��[)t5��췡]�g{`$��yYKAz�0]m|qQ)�lh�򯙄�]�(N��2s����^�I�k7��6���&&t����Վ�ʕ���/9 ����qe4ہ��"��#^�h��9ɽstjY$��(ϗߢ{��9=��}�k�o�Qq�H��g��#��Ć������O�K
��tQR���fyv��43���f@1�z9��q������NQ���/~��k��;rbVE�(��R����(���%ҋU��g������m���9�z֓��cr@v$��0�ӀC�군��y��q
`i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂lD.�����_R�i�{v��$�� ��r����/�Mּ~�)+LY�_f�$)X�P����%��q�!A���;+c� �}'��Ge@�a���&�$h�`2:��A?�l�M�(�QX�-�x9��y+��s�,}�`aD���5ʭ4��F�J[��]�H�X��ӯ@��g �t;D��eTq�	�.P!?�Ɖ�P�%��g����:�
n5�g���t��6�,�Š�4D�rO�tW\�y����#��gM������H\T�m`�S.�烌�9f�M�p��'��n~Ro;QHJ^�;�IZmdT�&愍d%��esV�ir�iM�?�$�1���+�����P�h�*�m�̞>�Ԩ3m�FJ�8����D�
!�$+Q�Fp(ݟ��L�b��eh���/h�D�+e���o�u���O� c\�����ͮXB�,��{E�i_�eR
R���6����9,<*���Ԗ������6���b�������ޅ��A}�z#1�
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
