interface VideoEmbedProps {
  url: string;
}

function getEmbedUrl(url: string): { embedUrl: string; isShort: boolean } | null {
  try {
    const parsed = new URL(url);

    if (parsed.hostname.includes('youtube.com') && parsed.searchParams.get('v')) {
      return { embedUrl: `https://www.youtube-nocookie.com/embed/${parsed.searchParams.get('v')}`, isShort: false };
    }

    if (parsed.hostname === 'youtu.be') {
      return { embedUrl: `https://www.youtube-nocookie.com/embed/${parsed.pathname.slice(1)}`, isShort: false };
    }

    if (parsed.hostname.includes('youtube.com') && parsed.pathname.startsWith('/shorts/')) {
      const id = parsed.pathname.replace('/shorts/', '');
      return { embedUrl: `https://www.youtube-nocookie.com/embed/${id}`, isShort: true };
    }

    if (parsed.hostname.includes('vimeo.com')) {
      return { embedUrl: `https://player.vimeo.com/video/${parsed.pathname.slice(1)}`, isShort: false };
    }

    return null;
  } catch {
    return null;
  }
}

export default function VideoEmbed({ url }: VideoEmbedProps) {
  const result = getEmbedUrl(url);

  if (!result) {
    return <p style={{ color: '#999', fontSize: '0.85rem' }}>Video preview not available for this URL.</p>;
  }

  const { embedUrl, isShort } = result;
  // 16:9 for regular videos, 9:16 for Shorts
  const paddingBottom = isShort ? '177.78%' : '56.25%';
  // Cap Shorts width so they don't stretch across the full screen on desktop
  const maxWidth = isShort ? '320px' : '100%';

  return (
    <div style={{ maxWidth, margin: isShort ? '0 auto' : undefined }}>
      <div style={{ position: 'relative', paddingBottom, height: 0, overflow: 'hidden' }}>
        <iframe
          src={embedUrl}
          title="Exercise video"
          allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
          allowFullScreen
          referrerPolicy="strict-origin-when-cross-origin"
          style={{
            position: 'absolute',
            top: 0,
            left: 0,
            width: '100%',
            height: '100%',
            border: 'none',
          }}
        />
      </div>
    </div>
  );
}