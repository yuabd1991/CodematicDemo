�}�� 
 �
  � ���Vrڍ]	0��� 3�x"��`ޮ��G�����6�ӭ����:k,���P�D�Mݼ��p�b�:��v�d���hlR����	���ZGRm]\	����jċ�u$�#y�]R��"�W�����R�c!!�E#v�J����A��Aw��x�N�@�=?h{e��e`%)~T�Y��8�:�wZ�N"��Yȟ=u�d$�_q����E.K:�8������P�m
u���P���x�ՁM8+��|�T�!8�1�	|�bsV4��C,v��*�ibVE�(��R����(���%ҋU��g������m���9�z֓��cr@v$��0�ӀC�군��y��q
`i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		BLL.BLL.Blog bll=new BLL.BLL.Blog();
		BLL.Model.Blog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblTitle.Text=model.Title;
		this.lblContent.Text=model.Content;
		this.lblDateCreated.Text=model.DateCreated.ToString();

	}


    }
}
