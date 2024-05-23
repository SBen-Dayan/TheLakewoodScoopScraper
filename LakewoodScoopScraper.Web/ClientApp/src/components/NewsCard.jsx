import dayjs from "dayjs"

export default function NewsCard({ newsItem: { url, title, excerpt, date, imageUrl, comments } }) {
    return <>
        <div className="col-md-6 card h-100 p-1">
            <div className="d-flex align-items-center justify-content-center" style={{ height: '400px' }}>
                <img src={imageUrl} className="card-img-top"
                    alt={title} style={{ maxHeight: '100%', maxWidth: '100%', objectFit: 'contain' }} />
            </div>
            <div className="card-body d-flex flex-column text-center">
                <a href={url}><h2>{title}</h2></a>
                <br />
                <p className="card-text" style={{ fontSize: 20 }}>{excerpt}</p>
                <br />
                <div className="row">
                    <div className="col-md-6">
                        <h5>{dayjs(date).format('MM/DD/YYYY')}</h5>
                    </div>
                    <div className="col-md-3 offset-md-3">comments : {comments || 'none'}</div>
                </div>
            </div>
        </div>
    </>
}