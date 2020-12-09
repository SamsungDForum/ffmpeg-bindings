using System;
using System.Runtime.InteropServices;

namespace FFmpegBindings.Interop
{
    public unsafe static partial class FFmpeg
    {
        [Obsolete("the old bitstream filtering API (using AVBitStreamFilterContext) is deprecated. Use av_bsf_free() from the new bitstream filtering API (using AVBSFContext).")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* @bsf);
        
        
        [Obsolete("the old bitstream filtering API (using AVBitStreamFilterContext) is deprecated. Use av_bsf_send_packet() and av_bsf_receive_packet() from the new bitstream filtering API (using AVBSFContext).")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        
        
        [Obsolete("the old bitstream filtering API (using AVBitStreamFilterContext) is deprecated. Use av_bsf_get_by_name(), av_bsf_alloc(), and av_bsf_init() from the new bitstream filtering API (using AVBSFContext).")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBitStreamFilterContext* av_bitstream_filter_init(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [Obsolete("the old bitstream filtering API (using AVBitStreamFilterContext) is deprecated. Use av_bsf_iterate() from the new bitstream filtering API (using AVBSFContext).")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* @f);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_alloc(AVBitStreamFilter* @filter, AVBSFContext** @ctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_bsf_flush(AVBSFContext* @ctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_bsf_free(AVBSFContext** @ctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBitStreamFilter* av_bsf_get_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVClass* av_bsf_get_class();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_get_null_filter(AVBSFContext** @bsf);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_init(AVBSFContext* @ctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBitStreamFilter* av_bsf_iterate(void** @opaque);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBSFList* av_bsf_list_alloc();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_list_append(AVBSFList* @lst, AVBSFContext* @bsf);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_list_append2(AVBSFList* @lst, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @bsf_name, AVDictionary** @options);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_list_finalize(AVBSFList** @lst, AVBSFContext** @bsf);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_bsf_list_free(AVBSFList** @lst);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_list_parse_str(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, AVBSFContext** @bsf);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVBitStreamFilter* av_bsf_next(void** @opaque);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_receive_packet(AVBSFContext* @ctx, AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_bsf_send_packet(AVBSFContext* @ctx, AVPacket* @pkt);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern ushort* av_codec_get_chroma_intra_matrix(AVCodecContext* @avctx);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* @avctx);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern uint av_codec_get_codec_properties(AVCodecContext* @avctx);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_codec_get_lowres(AVCodecContext* @avctx);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_codec_get_max_lowres(AVCodec* @codec);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVRational av_codec_get_pkt_timebase(AVCodecContext* @avctx);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_codec_get_seek_preroll(AVCodecContext* @avctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_codec_is_decoder(AVCodec* @codec);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_codec_is_encoder(AVCodec* @codec);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* av_codec_iterate(void** @opaque);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* av_codec_next(AVCodec* @c);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_codec_set_chroma_intra_matrix(AVCodecContext* @avctx, ushort* @val);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_codec_set_codec_descriptor(AVCodecContext* @avctx, AVCodecDescriptor* @desc);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_codec_set_lowres(AVCodecContext* @avctx, int @val);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_codec_set_pkt_timebase(AVCodecContext* @avctx, AVRational @val);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_codec_set_seek_preroll(AVCodecContext* @avctx, int @val);
        
        
        [Obsolete("Use av_packet_ref")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_copy_packet(AVPacket* @dst, AVPacket* @src);
        
        
        [Obsolete("Use av_packet_copy_props")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_copy_packet_side_data(AVPacket* @dst, AVPacket* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCPBProperties* av_cpb_properties_alloc(ulong* @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVD3D11VAContext* av_d3d11va_alloc_context();
        
        
        [Obsolete("Use av_packet_ref or av_packet_make_refcounted")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_dup_packet(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size);
        
        
        [Obsolete("Use av_packet_unref")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_free_packet(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_get_bits_per_sample(AVCodecID @codec_id);
        
        
        [Obsolete("see av_fourcc_make_string() and av_fourcc2str().")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern ulong av_get_codec_tag_string(byte* @buf, ulong @buf_size, uint @codec_tag);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_get_exact_bits_per_sample(AVCodecID @codec_id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string av_get_profile_name(AVCodec* @codec, int @profile);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_grow_packet(AVPacket* @pkt, int @grow_by);
        
        
        [Obsolete("AVHWaccel structures contain no user-serviceable parts, so this function should not be used.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVHWAccel* av_hwaccel_next(AVHWAccel* @hwaccel);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_init_packet(AVPacket* @pkt);
        
        
        [Obsolete("This function does nothing, and always returns 0. Be sure to build with thread support to get basic thread safety.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_lockmgr_register(av_lockmgr_register_cb_func @cb);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_new_packet(AVPacket* @pkt, int @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPacket* av_packet_alloc();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPacket* av_packet_clone(AVPacket* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_copy_props(AVPacket* @dst, AVPacket* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_packet_free(AVPacket** @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_packet_free_side_data(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int* @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_make_refcounted(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_make_writable(AVPacket* @pkt);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_merge_side_data(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_packet_move_ref(AVPacket* @dst, AVPacket* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern byte* av_packet_pack_dictionary(AVDictionary* @dict, int* @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_ref(AVPacket* @dst, AVPacket* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string av_packet_side_data_name(AVPacketSideDataType @type);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_split_side_data(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_packet_unpack_dictionary(byte* @data, int @size, AVDictionary** @dict);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_packet_unref(AVPacket* @pkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_parser_change(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_parser_close(AVCodecParserContext* @s);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecParserContext* av_parser_init(int @codec_id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecParser* av_parser_iterate(void** @opaque);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecParser* av_parser_next(AVCodecParser* @c);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
        
        
        [Obsolete("av_image_copy() instead.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_picture_copy(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [Obsolete("unused")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_picture_crop(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band);
        
        
        [Obsolete("unused")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int av_picture_pad(AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color);
        
        
        [Obsolete("the old bitstream filtering API (using AVBitStreamFilterContext) is deprecated. Use the new bitstream filtering API (using AVBSFContext).")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_register_bitstream_filter(AVBitStreamFilter* @bsf);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_register_codec_parser(AVCodecParser* @parser);
        
        
        [Obsolete("This function doesn't do anything.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_register_hwaccel(AVHWAccel* @hwaccel);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void av_shrink_packet(AVPacket* @pkt, int @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern uint av_xiphlacing(byte* @s, uint @v);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* @codec);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVChromaLocation avcodec_chroma_pos_to_enum(int @xpos, int @ypos);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_close(AVCodecContext* @avctx);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string avcodec_configuration();
        
        
        [Obsolete("The semantics of this function are ill-defined and it should not be used. If you need to transfer the stream parameters from one codec context to another, use an intermediate AVCodecParameters instance and the avcodec_parameters_from_context() / avcodec_parameters_to_context() functions.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_copy_context(AVCodecContext* @dest, AVCodecContext* @src);
        
        
        [Obsolete("Use avcodec_send_packet() and avcodec_receive_frame().")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_decode_audio4(AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
        
        
        [Obsolete("Use avcodec_send_packet() and avcodec_receive_frame().")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_decode_video2(AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_default_execute(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_default_execute2(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev);
        
        
        [Obsolete("use avcodec_send_frame()/avcodec_receive_packet() instead")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_encode_audio2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
        
        
        [Obsolete("use avcodec_send_frame()/avcodec_receive_packet() instead")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_encode_video2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_enum_to_chroma_pos(int* @xpos, int* @ypos, AVChromaLocation @pos);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* avcodec_find_decoder(AVCodecID @id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* avcodec_find_decoder_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* avcodec_find_encoder(AVCodecID @id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodec* avcodec_find_encoder_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_flush_buffers(AVCodecContext* @avctx);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_free_context(AVCodecContext** @avctx);
        
        
        [Obsolete("Use av_pix_fmt_get_chroma_sub_sample")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVClass* avcodec_get_class();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_get_context_defaults3(AVCodecContext* @s, AVCodec* @codec);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVClass* avcodec_get_frame_class();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecHWConfig* avcodec_get_hw_config(AVCodec* @codec, int @index);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_get_hw_frames_parameters(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string avcodec_get_name(AVCodecID @id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVClass* avcodec_get_subtitle_rect_class();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVMediaType avcodec_get_type(AVCodecID @codec_id);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_is_open(AVCodecContext* @s);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string avcodec_license();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern AVCodecParameters* avcodec_parameters_alloc();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_parameters_free(AVCodecParameters** @par);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern string avcodec_profile_name(AVCodecID @codec_id, int @profile);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_register(AVCodec* @codec);
        
        
        [Obsolete("")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_register_all();
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern uint avcodec_version();
        
        
        [Obsolete("unused")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avpicture_alloc(AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [Obsolete("use av_image_fill_arrays() instead.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avpicture_fill(AVPicture* @picture, byte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [Obsolete("unused")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avpicture_free(AVPicture* @picture);
        
        
        [Obsolete("use av_image_get_buffer_size() instead.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avpicture_get_size(AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [Obsolete("use av_image_copy_to_buffer() instead.")]
        [DllImport("libavcodec-juvo.so.58")]
        public static extern int avpicture_layout(AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, byte* @dest, int @dest_size);
        
        
        [DllImport("libavcodec-juvo.so.58")]
        public static extern void avsubtitle_free(AVSubtitle* @sub);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern AVInputFormat* av_input_audio_device_next(AVInputFormat* @d);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern AVInputFormat* av_input_video_device_next(AVInputFormat* @d);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavdevice-juvo.so.58")]
        public static extern string avdevice_configuration();
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern void avdevice_free_list_devices(AVDeviceInfoList** @device_list);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavdevice-juvo.so.58")]
        public static extern string avdevice_license();
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_list_input_sources(AVInputFormat* @device, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern int avdevice_list_output_sinks(AVOutputFormat* @device, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern void avdevice_register_all();
        
        
        [DllImport("libavdevice-juvo.so.58")]
        public static extern uint avdevice_version();
        
        
        [Obsolete("")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVABufferSinkParams* av_abuffersink_params_alloc();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern ulong av_buffersink_get_channel_layout(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_channels(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_format(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_h(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_sample_rate(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVRational av_buffersink_get_time_base(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVMediaType av_buffersink_get_type(AVFilterContext* @ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersink_get_w(AVFilterContext* @ctx);
        
        
        [Obsolete("")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVBufferSinkParams* av_buffersink_params_alloc();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersrc_close(AVFilterContext* @ctx, long @pts, uint @flags);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVBufferSrcParameters* av_buffersrc_parameters_alloc();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilter* av_filter_iterate(void** @opaque);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_config_links(AVFilterContext* @filter);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern string avfilter_configuration();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_free(AVFilterContext* @filter);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilter* avfilter_get_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVClass* avfilter_get_class();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilterGraph* avfilter_graph_alloc();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args, void* @opaque, AVFilterGraph* @graph_ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern byte* avfilter_graph_dump(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @options);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_graph_free(AVFilterGraph** @graph);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_parse(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_parse_ptr(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_parse2(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_queue_command(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @target, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, int @flags, double @ts);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_request_oldest(AVFilterGraph* @graph);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_graph_send_command(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @target, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_init_str(AVFilterContext* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilterInOut* avfilter_inout_alloc();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_inout_free(AVFilterInOut** @inout);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern string avfilter_license();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_link_free(AVFilterLink** @link);
        
        
        [Obsolete("Use av_buffersink_get_channels()")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_link_get_channels(AVFilterLink* @link);
        
        
        [Obsolete("applications are not supposed to mess with links, they should close the sinks.")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_link_set_closed(AVFilterLink* @link, int @closed);
        
        
        [Obsolete("")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVFilter* avfilter_next(AVFilter* @prev);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_pad_count(AVFilterPad* @pads);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx);
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_process_command(AVFilterContext* @filter, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
        
        
        [Obsolete("")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern int avfilter_register(AVFilter* @filter);
        
        
        [Obsolete("")]
        [DllImport("libavfilter-juvo.so.7")]
        public static extern void avfilter_register_all();
        
        
        [DllImport("libavfilter-juvo.so.7")]
        public static extern uint avfilter_version();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_apply_bitstream_filters(AVCodecContext* @codec, AVPacket* @pkt, AVBitStreamFilterContext* @bsfc);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecID av_codec_get_id(AVCodecTag** @tags, uint @tag);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint av_codec_get_tag(AVCodecTag** @tags, AVCodecID @id);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_codec_get_tag2(AVCodecTag** @tags, AVCodecID @id, uint* @tag);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_demuxer_iterate(void** @opaque);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_demuxer_open(AVFormatContext* @ic);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_dump_format(AVFormatContext* @ic, int @index, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @is_output);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_filename_number_test(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_find_default_stream_index(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_find_input_format(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodec* av_format_get_audio_codec(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern av_format_get_control_message_cb_func av_format_get_control_message_cb(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodec* av_format_get_data_codec(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_format_get_metadata_header_padding(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void* av_format_get_opaque(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern av_format_get_open_cb_func av_format_get_open_cb(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_format_get_probe_score(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodec* av_format_get_subtitle_codec(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodec* av_format_get_video_codec(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_inject_global_side_data(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_audio_codec(AVFormatContext* @s, AVCodec* @c);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_control_message_cb(AVFormatContext* @s, av_format_set_control_message_cb_callback_func @callback);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_data_codec(AVFormatContext* @s, AVCodec* @c);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_metadata_header_padding(AVFormatContext* @s, int @c);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_opaque(AVFormatContext* @s, void* @opaque);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_open_cb(AVFormatContext* @s, av_format_set_open_cb_callback_func @callback);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_subtitle_codec(AVFormatContext* @s, AVCodec* @c);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_format_set_video_codec(AVFormatContext* @s, AVCodec* @c);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_get_frame_filename(byte* @buf, int @buf_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_get_frame_filename2(byte* @buf, int @buf_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_get_output_timestamp(AVFormatContext* @s, int @stream, long* @dts, long* @wall);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecID av_guess_codec(AVOutputFormat* @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mime_type, AVMediaType @type);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVOutputFormat* av_guess_format(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mime_type);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_hex_dump(_iobuf* @f, byte* @buf, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_iformat_next(AVInputFormat* @f);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_match_ext(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @extensions);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVOutputFormat* av_muxer_iterate(void** @opaque);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVProgram* av_new_program(AVFormatContext* @s, int @id);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVOutputFormat* av_oformat_next(AVOutputFormat* @f);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_pkt_dump2(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_read_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_read_pause(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_read_play(AVFormatContext* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_register_all();
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_register_input_format(AVInputFormat* @format);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_register_output_format(AVOutputFormat* @format);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_sdp_create(AVFormatContext** @ac, int @n_files, byte* @buf, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_stream_add_side_data(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVRational av_stream_get_codec_timebase(AVStream* @st);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern long av_stream_get_end_pts(AVStream* @st);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecParserContext* av_stream_get_parser(AVStream* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVRational av_stream_get_r_frame_rate(AVStream* @s);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern byte* av_stream_get_recommended_encoder_configuration(AVStream* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, int* @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, int @size);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_stream_set_r_frame_rate(AVStream* @s, AVRational @r);
        
        
        [Obsolete("")]
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_stream_set_recommended_encoder_configuration(AVStream* @s, byte* @configuration);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_write_frame(AVFormatContext* @s, AVPacket* @pkt);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_write_trailer(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVFormatContext* avformat_alloc_context();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @format_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avformat_close_input(AVFormatContext** @s);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavformat-juvo.so.58")]
        public static extern string avformat_configuration();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_flush(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avformat_free_context(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVClass* avformat_get_class();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecTag* avformat_get_mov_audio_tags();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecTag* avformat_get_mov_video_tags();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecTag* avformat_get_riff_audio_tags();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVCodecTag* avformat_get_riff_video_tags();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_init_output(AVFormatContext* @s, AVDictionary** @options);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavformat-juvo.so.58")]
        public static extern string avformat_license();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @spec);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_network_deinit();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_network_init();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_open_input(AVFormatContext** @ps, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_queue_attached_pictures(AVFormatContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avformat_version();
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avformat_write_header(AVFormatContext* @s, AVDictionary** @options);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_accept(AVIOContext* @s, AVIOContext** @c);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_check(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_close(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_close_dir(AVIODirContext** @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_closep(AVIOContext** @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_context_free(AVIOContext** @s);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavformat-juvo.so.58")]
        public static extern string avio_enum_protocols(void** @opaque, int @output);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_feof(AVIOContext* @s);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavformat-juvo.so.58")]
        public static extern string avio_find_protocol_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_flush(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_free_directory_entry(AVIODirEntry** @entry);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_get_dyn_buf(AVIOContext* @s, byte** @pbuffer);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_handshake(AVIOContext* @c);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_open(AVIOContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_open_dir(AVIODirContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVDictionary** @options);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_open_dyn_buf(AVIOContext** @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_open2(AVIOContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_pause(AVIOContext* @h, int @pause);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_print_string_array(AVIOContext* @s, byte*[] @strings);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_printf(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern AVClass* avio_protocol_get_class(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_put_str(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_put_str16be(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_put_str16le(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_r8(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rb16(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rb24(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rb32(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern ulong avio_rb64(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_read(AVIOContext* @s, byte* @buf, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_read_partial(AVIOContext* @s, byte* @buf, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avio_read_to_bprint(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rl16(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rl24(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern uint avio_rl32(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern ulong avio_rl64(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern long avio_seek(AVIOContext* @s, long @offset, int @whence);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern long avio_size(AVIOContext* @s);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern long avio_skip(AVIOContext* @s, long @offset);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_w8(AVIOContext* @s, int @b);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wb16(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wb24(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wb32(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wb64(AVIOContext* @s, ulong @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wl16(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wl24(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wl32(AVIOContext* @s, uint @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_wl64(AVIOContext* @s, ulong @val);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_write(AVIOContext* @s, byte* @buf, int @size);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avpriv_io_delete(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url);
        
        
        [DllImport("libavformat-juvo.so.58")]
        public static extern int avpriv_io_move(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url_src, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url_dst);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_add_q(AVRational @b, AVRational @c);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_audio_fifo_free(AVAudioFifo* @af);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_audio_fifo_reset(AVAudioFifo* @af);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_size(AVAudioFifo* @af);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_space(AVAudioFifo* @af);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_bprint_channel_layout(AVBPrint* @bp, int @nb_channels, ulong @channel_layout);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_buffer_alloc(int @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_buffer_allocz(int @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_buffer_create(byte* @data, int @size, av_buffer_create_free_func @free, void* @opaque, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_buffer_default_free(void* @opaque, byte* @data);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_buffer_get_opaque(AVBufferRef* @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_buffer_get_ref_count(AVBufferRef* @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_buffer_is_writable(AVBufferRef* @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_buffer_make_writable(AVBufferRef** @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferPool* av_buffer_pool_init(int @size, av_buffer_pool_init_alloc_func @alloc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferPool* av_buffer_pool_init2(int @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_buffer_pool_uninit(AVBufferPool** @pool);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_buffer_realloc(AVBufferRef** @buf, int @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_buffer_ref(AVBufferRef* @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_buffer_unref(AVBufferRef** @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_calloc(ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern ulong av_channel_layout_extract_channel(ulong @channel_layout, int @index);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_chroma_location_from_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_chroma_location_name(AVChromaLocation @location);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_color_primaries_from_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_color_primaries_name(AVColorPrimaries @primaries);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_color_range_from_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_color_range_name(AVColorRange @range);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_color_space_from_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_color_space_name(AVColorSpace @space);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_color_transfer_from_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_color_transfer_name(AVColorTransferCharacteristic @transfer);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_compare_mod(ulong @a, ulong @b, ulong @mod);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_cpu_count();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern ulong av_cpu_max_align();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_d2q(double @d, int @max);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVClassCategory av_default_get_category(void* @ptr);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_default_item_name(void* @ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_count(AVDictionary* @m);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_dict_free(AVDictionary** @m);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVDictionaryEntry* av_dict_get(AVDictionary* @m, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_parse_string(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_set(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @value, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dict_set_int(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, long @value, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_div_q(AVRational @b, AVRational @c);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_encryption_info_add_side_data(AVEncryptionInfo* @info, ulong* @side_data_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVEncryptionInfo* av_encryption_info_alloc(uint @subsample_count, uint @key_id_size, uint @iv_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVEncryptionInfo* av_encryption_info_clone(AVEncryptionInfo* @info);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_encryption_info_free(AVEncryptionInfo* @info);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVEncryptionInfo* av_encryption_info_get_side_data(byte* @side_data, ulong @side_data_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_encryption_init_info_add_side_data(AVEncryptionInitInfo* @info, ulong* @side_data_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVEncryptionInitInfo* av_encryption_init_info_alloc(uint @system_id_size, uint @num_key_ids, uint @key_id_size, uint @data_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_encryption_init_info_free(AVEncryptionInitInfo* @info);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVEncryptionInitInfo* av_encryption_init_info_get_side_data(byte* @side_data, ulong @side_data_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFifoBuffer* av_fifo_alloc(uint @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFifoBuffer* av_fifo_alloc_array(ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fifo_drain(AVFifoBuffer* @f, int @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fifo_free(AVFifoBuffer* @f);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fifo_freep(AVFifoBuffer** @f);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_generic_peek(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_generic_peek_at(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_generic_read(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_generic_write(AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_grow(AVFifoBuffer* @f, uint @additional_space);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_realloc2(AVFifoBuffer* @f, uint @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_fifo_reset(AVFifoBuffer* @f);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_size(AVFifoBuffer* @f);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_fifo_space(AVFifoBuffer* @f);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern _iobuf* av_fopen_utf8(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mode);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_force_cpu_flags(int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_fourcc_make_string(byte* @buf, uint @fourcc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFrame* av_frame_alloc();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_apply_cropping(AVFrame* @frame, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFrame* av_frame_clone(AVFrame* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_copy(AVFrame* @dst, AVFrame* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_copy_props(AVFrame* @dst, AVFrame* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_free(AVFrame** @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_frame_get_best_effort_timestamp(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_get_buffer(AVFrame* @frame, int @align);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_frame_get_channel_layout(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_get_channels(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVColorRange av_frame_get_color_range(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVColorSpace av_frame_get_colorspace(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_get_decode_error_flags(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVDictionary* av_frame_get_metadata(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_frame_get_pkt_duration(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_frame_get_pkt_pos(AVFrame* @frame);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_get_pkt_size(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern sbyte* av_frame_get_qp_table(AVFrame* @f, int* @stride, int* @type);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_get_sample_rate(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_is_writable(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_make_writable(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_move_ref(AVFrame* @dst, AVFrame* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, int @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_ref(AVFrame* @dst, AVFrame* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_best_effort_timestamp(AVFrame* @frame, long @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_channel_layout(AVFrame* @frame, long @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_channels(AVFrame* @frame, int @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_color_range(AVFrame* @frame, AVColorRange @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_colorspace(AVFrame* @frame, AVColorSpace @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_decode_error_flags(AVFrame* @frame, int @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_metadata(AVFrame* @frame, AVDictionary* @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_pkt_duration(AVFrame* @frame, long @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_pkt_pos(AVFrame* @frame, long @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_pkt_size(AVFrame* @frame, int @val);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_frame_set_qp_table(AVFrame* @f, AVBufferRef* @buf, int @stride, int @type);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_set_sample_rate(AVFrame* @frame, int @val);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_frame_side_data_name(AVFrameSideDataType @type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_frame_unref(AVFrame* @frame);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_free(void* @ptr);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_freep(void* @ptr);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_gcd(long @a, long @b);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_gcd_q(AVRational @a, AVRational @b, int @max_den, AVRational @def);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_bytes_per_sample(AVSampleFormat @sample_fmt);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_channel_description(ulong @channel);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern ulong av_get_channel_layout(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_channel_layout_channel_index(ulong @channel_layout, ulong @channel);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_channel_layout_nb_channels(ulong @channel_layout);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_get_channel_layout_string(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_channel_name(ulong @channel);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_colorspace_name(AVColorSpace @val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_cpu_flags();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_get_default_channel_layout(int @nb_channels);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_extended_channel_layout(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, ulong* @channel_layout, int* @nb_channels);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_media_type_string(AVMediaType @media_type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte av_get_picture_type_char(AVPictureType @pict_type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixelFormat av_get_pix_fmt(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_pix_fmt_name(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVSampleFormat av_get_sample_fmt(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_get_sample_fmt_name(AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_get_standard_channel_layout(uint @index, ulong* @layout, byte** @name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_get_time_base_q();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_gettime();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_gettime_relative();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_gettime_relative_is_monotonic();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType @type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwdevice_ctx_create(AVBufferRef** @device_ctx, AVHWDeviceType @type, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device, AVDictionary* @opts, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwdevice_ctx_create_derived(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwdevice_ctx_create_derived_opts(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwdevice_ctx_init(AVBufferRef* @ref);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVHWDeviceType av_hwdevice_find_type_by_name(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* @hwconfig);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_hwdevice_get_type_name(AVHWDeviceType @type);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_hwdevice_hwconfig_alloc(AVBufferRef* @device_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType @prev);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_hwframe_constraints_free(AVHWFramesConstraints** @constraints);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* @device_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_ctx_create_derived(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_ctx_init(AVBufferRef* @ref);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_get_buffer(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_map(AVFrame* @dst, AVFrame* @src, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_transfer_data(AVFrame* @dst, AVFrame* @src, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_alloc(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_check_sar(uint @w, uint @h, AVRational @sar);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_check_size2(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_image_copy(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_copy_to_buffer(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_image_copy_uc_from(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_fill_arrays(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_fill_black(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_fill_linesizes(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_image_fill_max_pixsteps(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_fill_pointers(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_default_callback(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_format_line(void* @ptr, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_log_format_line2(void* @ptr, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_log_get_flags();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_log_get_level();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_once(void* @avcl, int @initial_level, int @subsequent_level, int* @state, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_set_callback(av_log_set_callback_callback_func @callback);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_set_flags(int @arg);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_log_set_level(int @level);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_log2(uint @v);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_log2_16bit(uint @v);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_malloc(ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_malloc_array(ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_mallocz(ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_mallocz_array(ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_max_alloc(ulong @max);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_memcpy_backptr(byte* @dst, int @back, int @cnt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_memdup(void* @p, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_mul_q(AVRational @b, AVRational @c);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVClass* av_opt_child_class_next(AVClass* @parent, AVClass* @prev);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_opt_child_next(void* @obj, void* @prev);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_copy(void* @dest, void* @src);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_double(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, double* @double_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_flags(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @flags_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_float(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, float* @float_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_int(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @int_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_int64(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, long* @int64_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_eval_q(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, AVRational* @q_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVOption* av_opt_find(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @unit, int @opt_flags, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVOption* av_opt_find2(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @unit, int @opt_flags, int @search_flags, void** @target_obj);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_flag_is_set(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @field_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @flag_name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_opt_free(void* @obj);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_opt_freep_ranges(AVOptionRanges** @ranges);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, byte** @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_channel_layout(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @ch_layout);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_dict_val(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_double(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, double* @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_image_size(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_int(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_key_value(byte** @ropts, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_pixel_fmt(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_q(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_sample_fmt(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_get_video_rate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_is_set_to_default(void* @obj, AVOption* @o);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_is_set_to_default_by_name(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVOption* av_opt_next(void* @obj, AVOption* @prev);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_opt_ptr(AVClass* @avclass, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_query_ranges(AVOptionRanges** @p0, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_query_ranges_default(AVOptionRanges** @p0, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_bin(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, byte* @val, int @size, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_channel_layout(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @ch_layout, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_opt_set_defaults(void* @s);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_opt_set_defaults2(void* @s, int @mask, int @flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_dict(void* @obj, AVDictionary** @options);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_dict_val(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVDictionary* @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_double(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, double @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_from_string(void* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @opts, byte** @shorthand, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_image_size(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @w, int @h, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_int(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_pixel_fmt(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_q(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_sample_fmt(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_set_video_rate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_parse_cpu_caps(uint* @flags, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_parse_cpu_flags(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern uint av_q2intfloat(AVRational @q);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_read_image_line(ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_read_image_line2(void* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_realloc(void* @ptr, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_reallocp(void* @ptr, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_rescale(long @a, long @b, long @c);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_rescale_q(long @a, AVRational @bq, AVRational @cq);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        
        
        [Obsolete("")]
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_set_cpu_flags_mask(int @mask);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_set_options_string(void* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @opts, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_strdup(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_strndup(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s, ulong @len);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVRational av_sub_q(AVRational @b, AVRational @c);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_timecode_adjust_ntsc_framenum2(int @framenum, int @fps);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_timecode_check_frame_rate(AVRational @rate);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern uint av_timecode_get_smpte_from_framenum(AVTimecode* @tc, int @framenum);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_timecode_init(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_timecode_init_from_string(AVTimecode* @tc, AVRational @rate, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, void* @log_ctx);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_timecode_make_mpeg_tc_string(byte* @buf, uint @tc25bit);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_timecode_make_smpte_tc_string(byte* @buf, uint @tcsmpte, int @prevent_df);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern byte* av_timecode_make_string(AVTimecode* @tc, byte* @buf, int @framenum);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_tree_destroy(AVTreeNode* @t);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_tree_enumerate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_tree_find(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void* av_tree_insert(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern AVTreeNode* av_tree_node_alloc();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern int av_usleep(uint @usec);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string av_version_info();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_vlog(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_write_image_line(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern void av_write_image_line2(void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string avutil_configuration();
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libavutil-juvo.so.56")]
        public static extern string avutil_license();
        
        
        [DllImport("libavutil-juvo.so.56")]
        public static extern uint avutil_version();
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libpostproc-juvo.so.55")]
        public static extern string postproc_configuration();
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libpostproc-juvo.so.55")]
        public static extern string postproc_license();
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern uint postproc_version();
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern void pp_free_context(void* @ppContext);
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern void pp_free_mode(void* @mode);
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern void* pp_get_context(int @width, int @height, int @flags);
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern void* pp_get_mode_by_name_and_quality(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @quality);
        
        
        [DllImport("libpostproc-juvo.so.55")]
        public static extern void pp_postprocess(ref byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern SwrContext* swr_alloc();
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern SwrContext* swr_alloc_set_opts(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_build_matrix(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern void swr_close(SwrContext* @s);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_convert(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_drop_output(SwrContext* @s, int @count);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern void swr_free(SwrContext** @s);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern AVClass* swr_get_class();
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern long swr_get_delay(SwrContext* @s, long @base);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_get_out_samples(SwrContext* @s, int @in_samples);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_init(SwrContext* @s);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_inject_silence(SwrContext* @s, int @count);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_is_initialized(SwrContext* @s);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern long swr_next_pts(SwrContext* @s, long @pts);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_set_channel_mapping(SwrContext* @s, int* @channel_map);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_set_compensation(SwrContext* @s, int @sample_delta, int @compensation_distance);
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern int swr_set_matrix(SwrContext* @s, double* @matrix, int @stride);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libswresample-juvo.so.3")]
        public static extern string swresample_configuration();
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libswresample-juvo.so.3")]
        public static extern string swresample_license();
        
        
        [DllImport("libswresample-juvo.so.3")]
        public static extern uint swresample_version();
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_addVec(SwsVector* @a, SwsVector* @b);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsContext* sws_alloc_context();
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsVector* sws_allocVec(int @length);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsVector* sws_cloneVec(SwsVector* @a);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_convVec(SwsVector* @a, SwsVector* @b);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_freeContext(SwsContext* @swsContext);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_freeFilter(SwsFilter* @filter);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_freeVec(SwsVector* @a);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern AVClass* sws_get_class();
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsContext* sws_getCachedContext(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int* sws_getCoefficients(int @colorspace);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsVector* sws_getConstVec(double @c, int @length);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsContext* sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsVector* sws_getGaussianVec(double @variance, double @quality);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern SwsVector* sws_getIdentityVec();
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_init_context(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_isSupportedInput(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_isSupportedOutput(AVPixelFormat @pix_fmt);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_normalizeVec(SwsVector* @a, double @height);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_printVec2(SwsVector* @a, AVClass* @log_ctx, int @log_level);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_scale(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_scaleVec(SwsVector* @a, double @scalar);
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern int sws_setColorspaceDetails(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_shiftVec(SwsVector* @a, int @shift);
        
        
        [Obsolete("")]
        [DllImport("libswscale-juvo.so.5")]
        public static extern void sws_subVec(SwsVector* @a, SwsVector* @b);
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libswscale-juvo.so.5")]
        public static extern string swscale_configuration();
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [DllImport("libswscale-juvo.so.5")]
        public static extern string swscale_license();
        
        
        [DllImport("libswscale-juvo.so.5")]
        public static extern uint swscale_version();
        
        
    }
}
