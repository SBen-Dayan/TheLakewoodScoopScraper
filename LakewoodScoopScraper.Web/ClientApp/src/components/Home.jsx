import axios from "axios"
import { useState, useEffect } from "react"
import NewsCard from "./NewsCard";

export default function Home() {
    const [newsItems, setNewsItems] = useState([]);

    useEffect(() => {
        (async function () {
            const { data } = await axios.get('/api/scraper/getNewsItems');
            setNewsItems(data);
        })();
    }, [])

    return <>
        <div className="row" style={{marginTop : 100}}>
            {newsItems.map(n => <NewsCard key={n.title} newsItem={n} />)}
        </div>
    </>

}